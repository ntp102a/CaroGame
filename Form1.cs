using GameCaro.Interface;
using GameCaro.Services.GetIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class frmCaroChess : Form
    {
        // Tach Static
        public static int cdStep = 100; // Buoc nhay cua 
        public static int cdTime = 15000; // Tong thoi gian mac dinh  = Level 1
        public static int cdInterval = 100; // Buoc nhay cua thoi gian
        #region field
        private CaroChess caroChess; // Field caroChess Xu li Su kien cua chess
        private readonly Graphics grs; // Xu li Do hoa
        readonly SocketManager socket; // Xu Li Gui Du lieu Mang LAN

        OpenFileDialog OpenFileDialog; // Mo/Dong File Nhac 
        string[] filePaths;
        string[] fileNames;


        #endregion
        public frmCaroChess()
        {
            InitializeComponent();
            caroChess = new ChessEvenPvC();
            caroChess.CreateChessPieces(); 
            grs = pnlChessBoard.CreateGraphics(); // Tao giao dien dau vao
            PvC.Click += PvC_Click;
            btnComputer.Click += PvC_Click;
            exitToolStripMenuItem.Click += btnExit_Click;
            socket = new SocketManager();
            prcbCoolDown.Step = cdStep; // Xu du lieu cho cbCoolDown
            prcbCoolDown.Maximum = cdTime;
            prcbCoolDown.Value = 0;

            tmCoolDown.Interval = cdInterval;


        }

        private void PvC_Click(object sender, EventArgs e)
        {
            caroChess = new ChessEvenPvC();
            caroChess.CreateChessPieces();
            grs.Clear(pnlChessBoard.BackColor);
            caroChess.StartGame(grs); //bat dau voi mode choi vs computer
            prcbCoolDown.Value = 0;
            tmCoolDown.Start();
        }
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            caroChess.DrawChessBoard(grs);
            caroChess.RepaintChess(grs);
        }
        private void frmCaroChess_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(192, 192, 192);
            btnComputer.BackColor = this.BackColor;
            btnNewGame.BackColor = this.BackColor;
            btnLAN.BackColor = this.BackColor;
            txbIP.BackColor = this.BackColor;

            btn2Player.BackColor = this.BackColor;
            btnExit.BackColor = this.BackColor;
            pnlChessBoard.BackColor = Color.White;

        }
        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)  //tham số của event, được tạo và gán giá trị bởi Visual C#.
        {
            if (!caroChess.Ready) // check chon mode
                return;
            if (caroChess.PlayChess(e.X, e.Y, grs)) //Xtrả về tọa độ x,y mà con trỏ đang ở lúc sự kiện khởi chạy
            {
                if (caroChess.Mode == 1)
                {
                    if (caroChess.CheckWin())
                    {
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        return;
                    }
                }
                else if (caroChess.Mode == 2)
                {
                    caroChess.LaunchComputer(grs);
                    if (caroChess.CheckWin())
                    {
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        return;
                    }
                }
                else if (caroChess.Mode == 3)
                {
                    pnlChessBoard.Enabled = false;

                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.Location));

                    Listen();
                    if (caroChess.CheckWin())
                    {
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        return;
                    }
                }
            }
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }

        public void OtherPlayerMark(Point point)
        {
            if (!caroChess.Ready)
                return;
            if (caroChess.PlayChess(point.X, point.Y, grs))
            {
                pnlChessBoard.Enabled = true;
                if (caroChess.CheckWin())
                {
                    tmCoolDown.Stop();
                    caroChess.EndGame();
                }
            }
        }
        private void PvsP(object sender, EventArgs e)
        {
            grs.Clear(pnlChessBoard.BackColor);
            caroChess = new ChessEvenPvP();
            caroChess.StartGame(grs);
            caroChess.CreateChessPieces();
            prcbCoolDown.Value = 0;
            tmCoolDown.Start();

        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.YesNo); ;
            if (caroChess.Mode != 3)
            {
                if (dlr == DialogResult.Yes)
                {

                    Application.Exit();
                }
            }

            else
            {
                if (dlr == DialogResult.Yes)
                {
                    try
                    {
                        socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    }
                    catch { }

                    Application.Exit();
                }
            }

        }
        private void NewGame()
        {
            grs.Clear(pnlChessBoard.BackColor);
            caroChess.StartLAN(grs);

            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {

            if (caroChess.Mode == 0)
            {
                MessageBox.Show("Chưa chọn chế độ chơi!", "Thông báo");
                return;
            }
            else if (caroChess.Mode == 1)
            {
                grs.Clear(pnlChessBoard.BackColor);
                caroChess.StartGame(grs);
            }
            else if (caroChess.Mode == 2)
            {
                grs.Clear(pnlChessBoard.BackColor);
                caroChess.StartGame(grs);
            }
            else
            {
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                grs.Clear(pnlChessBoard.BackColor);
                caroChess.StartLAN(grs);
                pnlChessBoard.Enabled = true;
            }
            tmCoolDown.Start();
            prcbCoolDown.Value = 0;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.Show();
        }
        private void btnLAN_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlChessBoard.BackColor);
            caroChess.StartLAN(grs);
            socket.IP = txbIP.Text;         //lay ipv4 cua may ghi vao o txtIP
            if (!socket.ConnectServer())    //tao may chu
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else                             // neu la may client thi ket noi toi may chu
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
                MessageBox.Show("Kết nối thành công");
            }
            tmCoolDown.Stop();
            prcbCoolDown.Value = 0;
        }
        private void frmCaroChess_Shown(object sender, EventArgs e)
        {
            txbIP.Text = GetIPv4.GetLocalIPv4(NetworkInterfaceType.Wireless80211); //mang wifi
            if (string.IsNullOrEmpty(txbIP.Text))         // neu dung mang cam day
            {
                txbIP.Text = GetIPv4.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
        void Listen()       //lang nghe trao doi qua lai giua 2 may
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();

        }
        private void ProcessData(SocketData data)       //xu ly du lieu khi choi
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:         //truyen thong bao
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.NEW_GAME:       //tao game moi
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.QUIT:          //thong bao khi nguoi kia thoat
                    tmCoolDown.Stop();
                    MessageBox.Show("Người chơi đã thoát!");
                    caroChess.Ready = false;
                    break;

                case (int)SocketCommand.SEND_POINT:     //hien thi x o khi nguoi choi danh
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcbCoolDown.Value = 0;
                        tmCoolDown.Start();
                        OtherPlayerMark(data.Point);
                    }));

                    break;
                case (int)SocketCommand.END_GAME:       //thong bao end game
                    break;
                default:
                    break;
            }
            Listen();
        }
        private void tmCoolDown_Tick(object sender, EventArgs e)    //chay thoi gian chờ
        {
            prcbCoolDown.PerformStep();

            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                tmCoolDown.Stop();          //thoi gian ma ngung thi thua
                caroChess.EndGame();

            }
        }

        #region Music
        //Them nhac
        private void addMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Mp3 files, mp4 files(*.mp3, *.mp4) |*.mp*";
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.Title = "Open";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = OpenFileDialog.FileNames; //lay cai duong dan
                fileNames = OpenFileDialog.SafeFileNames;  //lay ten file
                foreach (string item in fileNames)
                {
                    comboBox_choosemusic.Items.Add(item);       //them vao combobox music
                    
                }
            }
            if(comboBox_choosemusic.Items.Count > 0)
            {
                Media.URL = comboBox_choosemusic.Items[0].ToString();
                comboBox_choosemusic.SelectedIndex++;
            }
            
        }

        //click chon nhac
        private void comboBox_choosemusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            Media.URL = filePaths[comboBox_choosemusic.SelectedIndex];
        }

        //tu dong chuyen bai khi het nhac
        private void Media_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Media.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Timer.Interval = 100;
                Timer.Enabled = true;
            }
        }

        //thoi gian khi het nhac -> tu dong chuyen 
        private void Timer_event(object sender, EventArgs e)
        {
            if (comboBox_choosemusic.Items.Count > 1)
            {
                if (comboBox_choosemusic.SelectedIndex + 1 <= filePaths.Length - 1)
                {
                    comboBox_choosemusic.SelectedIndex++;
                    Timer.Enabled = false;
                }
                else
                {
                    comboBox_choosemusic.SelectedIndex = 0;
                    Timer.Enabled = false;
                }
            }
            else
            {
                Timer.Enabled = false;
                Media.URL = comboBox_choosemusic.Items[0].ToString();
            }
        }

        //lui nhac
        private void panel_luinhac_Click(object sender, EventArgs e)
        {
            if (comboBox_choosemusic.SelectedIndex > 0)
            {
                comboBox_choosemusic.SelectedIndex -= 1;
            }
        }

        //tiep tuc choi nhac khi bi dung
        private void panel_playmussic_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.play();
        }

        //dung nhac 
        private void panel_pausemussic_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.pause();
        }

        //chuyen sang bai tiep theo
        private void panel_chuyennnhac_Click(object sender, EventArgs e)
        {
            if (comboBox_choosemusic.SelectedIndex < comboBox_choosemusic.Items.Count - 1)
            {
                comboBox_choosemusic.SelectedIndex += 1;
            }
        }
        #endregion

        private void Level1_Click(object sender, EventArgs e)
        {
            prcbCoolDown.Maximum = 15000;
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            prcbCoolDown.Maximum = 12000;
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            prcbCoolDown.Maximum = 9000;
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            prcbCoolDown.Maximum = 6000;
        }

        private void Level5_Click(object sender, EventArgs e)
        {
            prcbCoolDown.Maximum = 3000;
        }
    }
}

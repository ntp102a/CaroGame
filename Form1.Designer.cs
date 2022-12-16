namespace GameCaro
{
    partial class frmCaroChess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaroChess));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PvC = new System.Windows.Forms.ToolStripMenuItem();
            this.PvP = new System.Windows.Forms.ToolStripMenuItem();
            this.addMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Level4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Level5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_chuyennnhac = new System.Windows.Forms.Panel();
            this.panel_pausemussic = new System.Windows.Forms.Panel();
            this.panel_playmussic = new System.Windows.Forms.Panel();
            this.panel_luinhac = new System.Windows.Forms.Panel();
            this.comboBox_choosemusic = new System.Windows.Forms.ComboBox();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlChessBoard.Location = new System.Drawing.Point(15, 55);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(752, 771);
            this.pnlChessBoard.TabIndex = 1;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChessBoard_MouseClick);
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.levelToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1126, 36);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.addMusic,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PvC,
            this.PvP});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.newToolStripMenuItem.Text = "New";
            // 
            // PvC
            // 
            this.PvC.Name = "PvC";
            this.PvC.Size = new System.Drawing.Size(176, 34);
            this.PvC.Text = "1 Player";
            this.PvC.Click += new System.EventHandler(this.PvC_Click);
            // 
            // PvP
            // 
            this.PvP.Name = "PvP";
            this.PvP.Size = new System.Drawing.Size(176, 34);
            this.PvP.Text = "2 Player";
            this.PvP.Click += new System.EventHandler(this.PvsP);
            // 
            // addMusic
            // 
            this.addMusic.Name = "addMusic";
            this.addMusic.Size = new System.Drawing.Size(199, 34);
            this.addMusic.Text = "Add Music";
            this.addMusic.Click += new System.EventHandler(this.addMusic_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Level1,
            this.Level2,
            this.Level3,
            this.Level4,
            this.Level5});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // Level1
            // 
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(124, 34);
            this.Level1.Text = "1";
            this.Level1.Click += new System.EventHandler(this.Level1_Click);
            // 
            // Level2
            // 
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(124, 34);
            this.Level2.Text = "2";
            this.Level2.Click += new System.EventHandler(this.Level2_Click);
            // 
            // Level3
            // 
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(124, 34);
            this.Level3.Text = "3";
            this.Level3.Click += new System.EventHandler(this.Level3_Click);
            // 
            // Level4
            // 
            this.Level4.Name = "Level4";
            this.Level4.Size = new System.Drawing.Size(124, 34);
            this.Level4.Text = "4";
            this.Level4.Click += new System.EventHandler(this.Level4_Click);
            // 
            // Level5
            // 
            this.Level5.Name = "Level5";
            this.Level5.Size = new System.Drawing.Size(124, 34);
            this.Level5.Text = "5";
            this.Level5.Click += new System.EventHandler(this.Level5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel_chuyennnhac);
            this.panel1.Controls.Add(this.panel_pausemussic);
            this.panel1.Controls.Add(this.panel_playmussic);
            this.panel1.Controls.Add(this.panel_luinhac);
            this.panel1.Controls.Add(this.comboBox_choosemusic);
            this.panel1.Controls.Add(this.Media);
            this.panel1.Controls.Add(this.prcbCoolDown);
            this.panel1.Controls.Add(this.btnLAN);
            this.panel1.Controls.Add(this.txbIP);
            this.panel1.Controls.Add(this.ptbIcon);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnComputer);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btn2Player);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(774, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 810);
            this.panel1.TabIndex = 9;
            // 
            // panel_chuyennnhac
            // 
            this.panel_chuyennnhac.BackColor = System.Drawing.Color.Gray;
            this.panel_chuyennnhac.BackgroundImage = global::GameCaro.Properties.Resources.right_arrow_black_triangle;
            this.panel_chuyennnhac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_chuyennnhac.Location = new System.Drawing.Point(255, 498);
            this.panel_chuyennnhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_chuyennnhac.Name = "panel_chuyennnhac";
            this.panel_chuyennnhac.Size = new System.Drawing.Size(40, 38);
            this.panel_chuyennnhac.TabIndex = 14;
            this.panel_chuyennnhac.Click += new System.EventHandler(this.panel_chuyennnhac_Click);
            // 
            // panel_pausemussic
            // 
            this.panel_pausemussic.BackColor = System.Drawing.Color.Gray;
            this.panel_pausemussic.BackgroundImage = global::GameCaro.Properties.Resources.pause;
            this.panel_pausemussic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_pausemussic.Location = new System.Drawing.Point(186, 498);
            this.panel_pausemussic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_pausemussic.Name = "panel_pausemussic";
            this.panel_pausemussic.Size = new System.Drawing.Size(40, 38);
            this.panel_pausemussic.TabIndex = 14;
            this.panel_pausemussic.Click += new System.EventHandler(this.panel_pausemussic_Click);
            // 
            // panel_playmussic
            // 
            this.panel_playmussic.BackColor = System.Drawing.Color.Gray;
            this.panel_playmussic.BackgroundImage = global::GameCaro.Properties.Resources.play_button;
            this.panel_playmussic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_playmussic.Location = new System.Drawing.Point(120, 498);
            this.panel_playmussic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_playmussic.Name = "panel_playmussic";
            this.panel_playmussic.Size = new System.Drawing.Size(40, 38);
            this.panel_playmussic.TabIndex = 14;
            this.panel_playmussic.Click += new System.EventHandler(this.panel_playmussic_Click);
            // 
            // panel_luinhac
            // 
            this.panel_luinhac.BackColor = System.Drawing.Color.Gray;
            this.panel_luinhac.BackgroundImage = global::GameCaro.Properties.Resources.left_arrow_black_triangular_shape;
            this.panel_luinhac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_luinhac.Location = new System.Drawing.Point(50, 498);
            this.panel_luinhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_luinhac.Name = "panel_luinhac";
            this.panel_luinhac.Size = new System.Drawing.Size(40, 38);
            this.panel_luinhac.TabIndex = 13;
            this.panel_luinhac.Click += new System.EventHandler(this.panel_luinhac_Click);
            // 
            // comboBox_choosemusic
            // 
            this.comboBox_choosemusic.FormattingEnabled = true;
            this.comboBox_choosemusic.Location = new System.Drawing.Point(22, 451);
            this.comboBox_choosemusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_choosemusic.Name = "comboBox_choosemusic";
            this.comboBox_choosemusic.Size = new System.Drawing.Size(308, 28);
            this.comboBox_choosemusic.TabIndex = 12;
            this.comboBox_choosemusic.SelectedIndexChanged += new System.EventHandler(this.comboBox_choosemusic_SelectedIndexChanged);
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(249, 182);
            this.Media.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(10, 10);
            this.Media.TabIndex = 11;
            this.Media.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Media_PlayStateChange);
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(22, 399);
            this.prcbCoolDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(309, 35);
            this.prcbCoolDown.TabIndex = 10;
            // 
            // btnLAN
            // 
            this.btnLAN.BackColor = System.Drawing.Color.Black;
            this.btnLAN.FlatAppearance.BorderSize = 0;
            this.btnLAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.ForeColor = System.Drawing.Color.White;
            this.btnLAN.Image = global::GameCaro.Properties.Resources.icons8_router_50;
            this.btnLAN.Location = new System.Drawing.Point(22, 224);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(150, 143);
            this.btnLAN.TabIndex = 9;
            this.btnLAN.Text = "LAN";
            this.btnLAN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLAN.UseVisualStyleBackColor = false;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // txbIP
            // 
            this.txbIP.BackColor = System.Drawing.Color.Black;
            this.txbIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIP.ForeColor = System.Drawing.Color.White;
            this.txbIP.Location = new System.Drawing.Point(180, 258);
            this.txbIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(149, 26);
            this.txbIP.TabIndex = 8;
            this.txbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackColor = System.Drawing.SystemColors.Control;
            this.ptbIcon.BackgroundImage = global::GameCaro.Properties.Resources.Game;
            this.ptbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbIcon.InitialImage = null;
            this.ptbIcon.Location = new System.Drawing.Point(50, 5);
            this.ptbIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(273, 215);
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImage = global::GameCaro.Properties.Resources.icons8_shutdown_50;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(181, 676);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 116);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnComputer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComputer.FlatAppearance.BorderSize = 0;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnComputer.Image = global::GameCaro.Properties.Resources.icons8_bot_60_1_;
            this.btnComputer.Location = new System.Drawing.Point(22, 562);
            this.btnComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(150, 102);
            this.btnComputer.TabIndex = 5;
            this.btnComputer.Text = "Computer";
            this.btnComputer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.PvC_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewGame.BackgroundImage = global::GameCaro.Properties.Resources.icons8_game_controller_60;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.Location = new System.Drawing.Point(22, 676);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 112);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btn2Player
            // 
            this.btn2Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2Player.BackgroundImage = global::GameCaro.Properties.Resources._2player;
            this.btn2Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn2Player.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn2Player.FlatAppearance.BorderSize = 0;
            this.btn2Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player.ForeColor = System.Drawing.SystemColors.Control;
            this.btn2Player.Location = new System.Drawing.Point(181, 562);
            this.btn2Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(150, 102);
            this.btn2Player.TabIndex = 6;
            this.btn2Player.Text = "2 Player";
            this.btn2Player.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn2Player.UseVisualStyleBackColor = false;
            this.btn2Player.Click += new System.EventHandler(this.PvsP);
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_event);
            // 
            // frmCaroChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1126, 846);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCaroChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro";
            this.Load += new System.EventHandler(this.frmCaroChess_Load);
            this.Shown += new System.EventHandler(this.frmCaroChess_Shown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PvC;
        private System.Windows.Forms.ToolStripMenuItem PvP;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Panel panel_chuyennnhac;
        private System.Windows.Forms.Panel panel_pausemussic;
        private System.Windows.Forms.Panel panel_playmussic;
        private System.Windows.Forms.Panel panel_luinhac;
        private System.Windows.Forms.ComboBox comboBox_choosemusic;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.ToolStripMenuItem addMusic;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Level1;
        private System.Windows.Forms.ToolStripMenuItem Level2;
        private System.Windows.Forms.ToolStripMenuItem Level3;
        private System.Windows.Forms.ToolStripMenuItem Level4;
        private System.Windows.Forms.ToolStripMenuItem Level5;
    }
}


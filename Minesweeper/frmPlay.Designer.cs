namespace Minesweeper
{
    partial class frmPlay
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
            this.pnlFull = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLayOut = new System.Windows.Forms.Panel();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuide = new System.Windows.Forms.Button();
            this.pnlPlayState = new System.Windows.Forms.Panel();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblSoMinFlag = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pbxState = new System.Windows.Forms.PictureBox();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.rdo2Player = new System.Windows.Forms.RadioButton();
            this.rdo1Player = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1Player = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1PlayerLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1PlayerLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1PlayerLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2Player = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2PlayerLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2PlayerLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu2PlayerLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetupGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeeRankings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeeRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFull.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlLayOut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPlayState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxState)).BeginInit();
            this.pnlShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFull
            // 
            this.pnlFull.Controls.Add(this.panel3);
            this.pnlFull.Controls.Add(this.pnlTitle);
            this.pnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFull.Location = new System.Drawing.Point(0, 0);
            this.pnlFull.Name = "pnlFull";
            this.pnlFull.Size = new System.Drawing.Size(871, 514);
            this.pnlFull.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlLayOut);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pnlPlayState);
            this.panel3.Controls.Add(this.pnlShow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 406);
            this.panel3.TabIndex = 5;
            // 
            // pnlLayOut
            // 
            this.pnlLayOut.BackColor = System.Drawing.Color.Black;
            this.pnlLayOut.BackgroundImage = global::Minesweeper.Properties.Resources.background;
            this.pnlLayOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLayOut.Controls.Add(this.pnlPlay);
            this.pnlLayOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayOut.Location = new System.Drawing.Point(0, 71);
            this.pnlLayOut.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLayOut.Name = "pnlLayOut";
            this.pnlLayOut.Size = new System.Drawing.Size(585, 232);
            this.pnlLayOut.TabIndex = 6;
            // 
            // pnlPlay
            // 
            this.pnlPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlay.BackColor = System.Drawing.Color.Aqua;
            this.pnlPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlay.Location = new System.Drawing.Point(18, 19);
            this.pnlPlay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(549, 193);
            this.pnlPlay.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::Minesweeper.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnResetGame);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnGuide);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 103);
            this.panel2.TabIndex = 1;
            // 
            // btnResetGame
            // 
            this.btnResetGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnResetGame.AutoSize = true;
            this.btnResetGame.BackColor = System.Drawing.Color.Aqua;
            this.btnResetGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetGame.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnResetGame.FlatAppearance.BorderSize = 3;
            this.btnResetGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetGame.Image = global::Minesweeper.Properties.Resources.reset;
            this.btnResetGame.Location = new System.Drawing.Point(239, 5);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(107, 67);
            this.btnResetGame.TabIndex = 1;
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.Aqua;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Image = global::Minesweeper.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(101, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 67);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuide.AutoSize = true;
            this.btnGuide.BackColor = System.Drawing.Color.Aqua;
            this.btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuide.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGuide.FlatAppearance.BorderSize = 3;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGuide.Image = global::Minesweeper.Properties.Resources.idea;
            this.btnGuide.Location = new System.Drawing.Point(377, 5);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(107, 67);
            this.btnGuide.TabIndex = 1;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // pnlPlayState
            // 
            this.pnlPlayState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlPlayState.BackgroundImage = global::Minesweeper.Properties.Resources.background;
            this.pnlPlayState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayState.Controls.Add(this.lblPlayer1);
            this.pnlPlayState.Controls.Add(this.lblPlayer2);
            this.pnlPlayState.Controls.Add(this.lblSoMinFlag);
            this.pnlPlayState.Controls.Add(this.lblTime);
            this.pnlPlayState.Controls.Add(this.pbxState);
            this.pnlPlayState.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlayState.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPlayState.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayState.Name = "pnlPlayState";
            this.pnlPlayState.Size = new System.Drawing.Size(585, 71);
            this.pnlPlayState.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer1.BackColor = System.Drawing.Color.Lime;
            this.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlayer1.Location = new System.Drawing.Point(151, 14);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(90, 38);
            this.lblPlayer1.TabIndex = 3;
            this.lblPlayer1.Text = "Player1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer2.BackColor = System.Drawing.Color.DimGray;
            this.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPlayer2.Location = new System.Drawing.Point(329, 14);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(90, 38);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoMinFlag
            // 
            this.lblSoMinFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoMinFlag.BackColor = System.Drawing.Color.SandyBrown;
            this.lblSoMinFlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSoMinFlag.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoMinFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSoMinFlag.Location = new System.Drawing.Point(445, 14);
            this.lblSoMinFlag.Name = "lblSoMinFlag";
            this.lblSoMinFlag.Size = new System.Drawing.Size(76, 38);
            this.lblSoMinFlag.TabIndex = 1;
            this.lblSoMinFlag.Text = "0";
            this.lblSoMinFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(50, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 38);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxState
            // 
            this.pbxState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxState.BackgroundImage = global::Minesweeper.Properties.Resources.faceVui;
            this.pbxState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxState.Location = new System.Drawing.Point(266, 14);
            this.pbxState.Name = "pbxState";
            this.pbxState.Size = new System.Drawing.Size(38, 38);
            this.pbxState.TabIndex = 1;
            this.pbxState.TabStop = false;
            this.pbxState.UseWaitCursor = true;
            this.pbxState.BackgroundImageChanged += new System.EventHandler(this.pbxState_BackgroundImageChanged);
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.Color.SandyBrown;
            this.pnlShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlShow.Controls.Add(this.cboLevel);
            this.pnlShow.Controls.Add(this.panel1);
            this.pnlShow.Controls.Add(this.rdo2Player);
            this.pnlShow.Controls.Add(this.rdo1Player);
            this.pnlShow.Controls.Add(this.label3);
            this.pnlShow.Controls.Add(this.label2);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlShow.Location = new System.Drawing.Point(585, 0);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(286, 406);
            this.pnlShow.TabIndex = 0;
            // 
            // cboLevel
            // 
            this.cboLevel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(68, 200);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(197, 42);
            this.cboLevel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnSetup);
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackgroundImage = global::Minesweeper.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPlay.FlatAppearance.BorderSize = 3;
            this.btnPlay.Location = new System.Drawing.Point(21, 29);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 73);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetup.AutoSize = true;
            this.btnSetup.BackgroundImage = global::Minesweeper.Properties.Resources.setup;
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetup.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSetup.FlatAppearance.BorderSize = 3;
            this.btnSetup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSetup.Location = new System.Drawing.Point(155, 29);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(110, 73);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // rdo2Player
            // 
            this.rdo2Player.AutoSize = true;
            this.rdo2Player.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo2Player.Location = new System.Drawing.Point(89, 105);
            this.rdo2Player.Name = "rdo2Player";
            this.rdo2Player.Size = new System.Drawing.Size(130, 38);
            this.rdo2Player.TabIndex = 1;
            this.rdo2Player.TabStop = true;
            this.rdo2Player.Text = "2 Player";
            this.rdo2Player.UseVisualStyleBackColor = true;
            // 
            // rdo1Player
            // 
            this.rdo1Player.AutoSize = true;
            this.rdo1Player.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1Player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rdo1Player.Location = new System.Drawing.Point(89, 61);
            this.rdo1Player.Name = "rdo1Player";
            this.rdo1Player.Size = new System.Drawing.Size(130, 38);
            this.rdo1Player.TabIndex = 1;
            this.rdo1Player.TabStop = true;
            this.rdo1Player.Text = "1 Player";
            this.rdo1Player.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(27, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Players:";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.menuStrip1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(871, 108);
            this.pnlTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(237, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "MINESWEEPER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlay,
            this.mnuSetupGame,
            this.mnuSeeRankings,
            this.mnuSetting,
            this.mnuSeeRules,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(871, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuPlay
            // 
            this.mnuPlay.BackColor = System.Drawing.Color.DarkRed;
            this.mnuPlay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu1Player,
            this.mnu2Player});
            this.mnuPlay.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuPlay.Name = "mnuPlay";
            this.mnuPlay.Size = new System.Drawing.Size(64, 29);
            this.mnuPlay.Text = "Play";
            // 
            // mnu1Player
            // 
            this.mnu1Player.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu1PlayerLevel1,
            this.mnu1PlayerLevel2,
            this.mnu1PlayerLevel3});
            this.mnu1Player.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu1Player.Name = "mnu1Player";
            this.mnu1Player.Size = new System.Drawing.Size(205, 30);
            this.mnu1Player.Text = "Play 1 Person";
            // 
            // mnu1PlayerLevel1
            // 
            this.mnu1PlayerLevel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu1PlayerLevel1.Name = "mnu1PlayerLevel1";
            this.mnu1PlayerLevel1.Size = new System.Drawing.Size(152, 30);
            this.mnu1PlayerLevel1.Text = "Level 1";
            this.mnu1PlayerLevel1.Click += new System.EventHandler(this.mnu1PlayerLevel1_Click);
            // 
            // mnu1PlayerLevel2
            // 
            this.mnu1PlayerLevel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu1PlayerLevel2.Name = "mnu1PlayerLevel2";
            this.mnu1PlayerLevel2.Size = new System.Drawing.Size(152, 30);
            this.mnu1PlayerLevel2.Text = "Level 2";
            this.mnu1PlayerLevel2.Click += new System.EventHandler(this.mnu1PlayerLevel2_Click);
            // 
            // mnu1PlayerLevel3
            // 
            this.mnu1PlayerLevel3.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu1PlayerLevel3.Name = "mnu1PlayerLevel3";
            this.mnu1PlayerLevel3.Size = new System.Drawing.Size(152, 30);
            this.mnu1PlayerLevel3.Text = "Level 3";
            this.mnu1PlayerLevel3.Click += new System.EventHandler(this.mnu1PlayerLevel3_Click);
            // 
            // mnu2Player
            // 
            this.mnu2Player.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu2PlayerLevel1,
            this.mnu2PlayerLevel2,
            this.mnu2PlayerLevel3});
            this.mnu2Player.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu2Player.Name = "mnu2Player";
            this.mnu2Player.Size = new System.Drawing.Size(205, 30);
            this.mnu2Player.Text = "Play 2 Person";
            // 
            // mnu2PlayerLevel1
            // 
            this.mnu2PlayerLevel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu2PlayerLevel1.Name = "mnu2PlayerLevel1";
            this.mnu2PlayerLevel1.Size = new System.Drawing.Size(152, 30);
            this.mnu2PlayerLevel1.Text = "Level 1";
            this.mnu2PlayerLevel1.Click += new System.EventHandler(this.mnu2PlayerLevel1_Click);
            // 
            // mnu2PlayerLevel2
            // 
            this.mnu2PlayerLevel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu2PlayerLevel2.Name = "mnu2PlayerLevel2";
            this.mnu2PlayerLevel2.Size = new System.Drawing.Size(152, 30);
            this.mnu2PlayerLevel2.Text = "Level 2";
            this.mnu2PlayerLevel2.Click += new System.EventHandler(this.mnu2PlayerLevel2_Click);
            // 
            // mnu2PlayerLevel3
            // 
            this.mnu2PlayerLevel3.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnu2PlayerLevel3.Name = "mnu2PlayerLevel3";
            this.mnu2PlayerLevel3.Size = new System.Drawing.Size(152, 30);
            this.mnu2PlayerLevel3.Text = "Level 3";
            this.mnu2PlayerLevel3.Click += new System.EventHandler(this.mnu2PlayerLevel3_Click);
            // 
            // mnuSetupGame
            // 
            this.mnuSetupGame.BackColor = System.Drawing.Color.DarkRed;
            this.mnuSetupGame.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuSetupGame.Name = "mnuSetupGame";
            this.mnuSetupGame.Size = new System.Drawing.Size(124, 29);
            this.mnuSetupGame.Text = "Setup Game";
            this.mnuSetupGame.Click += new System.EventHandler(this.mnuSetupGame_Click);
            // 
            // mnuSeeRankings
            // 
            this.mnuSeeRankings.BackColor = System.Drawing.Color.DarkRed;
            this.mnuSeeRankings.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuSeeRankings.Name = "mnuSeeRankings";
            this.mnuSeeRankings.Size = new System.Drawing.Size(135, 29);
            this.mnuSeeRankings.Text = "See Rankings";
            this.mnuSeeRankings.Click += new System.EventHandler(this.mnuSeeRankings_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.BackColor = System.Drawing.Color.DarkRed;
            this.mnuSetting.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(83, 29);
            this.mnuSetting.Text = "Setting";
            this.mnuSetting.Click += new System.EventHandler(this.mnuSetting_Click);
            // 
            // mnuSeeRules
            // 
            this.mnuSeeRules.BackColor = System.Drawing.Color.DarkRed;
            this.mnuSeeRules.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuSeeRules.Name = "mnuSeeRules";
            this.mnuSeeRules.Size = new System.Drawing.Size(102, 29);
            this.mnuSeeRules.Text = "See Rules";
            this.mnuSeeRules.Click += new System.EventHandler(this.mnuSeeRules_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.DarkRed;
            this.mnuExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(61, 29);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 514);
            this.Controls.Add(this.pnlFull);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlay_FormClosing);
            this.Load += new System.EventHandler(this.frmPlay_Load);
            this.pnlFull.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlLayOut.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPlayState.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxState)).EndInit();
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFull;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlPlayState;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSoMinFlag;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.RadioButton rdo2Player;
        private System.Windows.Forms.RadioButton rdo1Player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPlay;
        private System.Windows.Forms.ToolStripMenuItem mnu1Player;
        private System.Windows.Forms.ToolStripMenuItem mnu2Player;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupGame;
        private System.Windows.Forms.ToolStripMenuItem mnuSeeRankings;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuSeeRules;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLayOut;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.PictureBox pbxState;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.ToolStripMenuItem mnu1PlayerLevel1;
        private System.Windows.Forms.ToolStripMenuItem mnu1PlayerLevel2;
        private System.Windows.Forms.ToolStripMenuItem mnu1PlayerLevel3;
        private System.Windows.Forms.ToolStripMenuItem mnu2PlayerLevel1;
        private System.Windows.Forms.ToolStripMenuItem mnu2PlayerLevel2;
        private System.Windows.Forms.ToolStripMenuItem mnu2PlayerLevel3;
    }
}


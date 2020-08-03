namespace Minesweeper
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeeRankings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn1Player = new System.Windows.Forms.Button();
            this.btnSeeRules = new System.Windows.Forms.Button();
            this.btnSetupGame = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(113, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "MINESWEEPER";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 71);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 583);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::Minesweeper.Properties.Resources.backgroundMenu;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnSeeRankings);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btn1Player);
            this.panel2.Controls.Add(this.btnSeeRules);
            this.panel2.Controls.Add(this.btnSetupGame);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btn2Player);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 577);
            this.panel2.TabIndex = 7;
            // 
            // btnSeeRankings
            // 
            this.btnSeeRankings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeeRankings.AutoSize = true;
            this.btnSeeRankings.BackColor = System.Drawing.Color.Wheat;
            this.btnSeeRankings.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeRankings.Location = new System.Drawing.Point(150, 281);
            this.btnSeeRankings.Name = "btnSeeRankings";
            this.btnSeeRankings.Size = new System.Drawing.Size(316, 57);
            this.btnSeeRankings.TabIndex = 3;
            this.btnSeeRankings.Text = "See Rankings";
            this.btnSeeRankings.UseVisualStyleBackColor = false;
            this.btnSeeRankings.Click += new System.EventHandler(this.btnSeeRankings_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Wheat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(150, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(316, 57);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn1Player
            // 
            this.btn1Player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn1Player.AutoSize = true;
            this.btn1Player.BackColor = System.Drawing.Color.Wheat;
            this.btn1Player.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Player.Location = new System.Drawing.Point(150, 71);
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size(316, 57);
            this.btn1Player.TabIndex = 0;
            this.btn1Player.Text = "Play 1 Person";
            this.btn1Player.UseVisualStyleBackColor = false;
            this.btn1Player.Click += new System.EventHandler(this.btn1Player_Click);
            // 
            // btnSeeRules
            // 
            this.btnSeeRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeeRules.AutoSize = true;
            this.btnSeeRules.BackColor = System.Drawing.Color.Wheat;
            this.btnSeeRules.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeRules.Location = new System.Drawing.Point(150, 421);
            this.btnSeeRules.Name = "btnSeeRules";
            this.btnSeeRules.Size = new System.Drawing.Size(316, 57);
            this.btnSeeRules.TabIndex = 5;
            this.btnSeeRules.Text = "See Rules";
            this.btnSeeRules.UseVisualStyleBackColor = false;
            this.btnSeeRules.Click += new System.EventHandler(this.btnSeeRules_Click);
            // 
            // btnSetupGame
            // 
            this.btnSetupGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetupGame.AutoSize = true;
            this.btnSetupGame.BackColor = System.Drawing.Color.Wheat;
            this.btnSetupGame.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetupGame.Location = new System.Drawing.Point(150, 211);
            this.btnSetupGame.Name = "btnSetupGame";
            this.btnSetupGame.Size = new System.Drawing.Size(316, 57);
            this.btnSetupGame.TabIndex = 2;
            this.btnSetupGame.Text = "Setup Game";
            this.btnSetupGame.UseVisualStyleBackColor = false;
            this.btnSetupGame.Click += new System.EventHandler(this.btnSetupGame_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSetting.AutoSize = true;
            this.btnSetting.BackColor = System.Drawing.Color.Wheat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(150, 351);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(316, 57);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btn2Player
            // 
            this.btn2Player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn2Player.AutoSize = true;
            this.btn2Player.BackColor = System.Drawing.Color.Wheat;
            this.btn2Player.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player.Location = new System.Drawing.Point(150, 141);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(316, 57);
            this.btn2Player.TabIndex = 1;
            this.btn2Player.Text = "Play 2 Person";
            this.btn2Player.UseVisualStyleBackColor = false;
            this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(623, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game MinesWeeper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSeeRankings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Button btnSeeRules;
        private System.Windows.Forms.Button btnSetupGame;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btn2Player;
    }
}
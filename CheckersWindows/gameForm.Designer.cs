namespace CheckersWindows
{
    public partial class gameForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxplayer1 = new System.Windows.Forms.PictureBox();
            this.ScorePlayer1 = new System.Windows.Forms.TextBox();
            this.Score1 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBoxplayer2 = new System.Windows.Forms.PictureBox();
            this.ScorePlayer2 = new System.Windows.Forms.TextBox();
            this.Score2 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxplayer1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxplayer2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PictureBoxplayer1);
            this.panel1.Controls.Add(this.ScorePlayer1);
            this.panel1.Controls.Add(this.Score1);
            this.panel1.Controls.Add(this.Player1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 120);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PictureBoxplayer1
            // 
            this.PictureBoxplayer1.Location = new System.Drawing.Point(11, 32);
            this.PictureBoxplayer1.Name = "PictureBoxplayer1";
            this.PictureBoxplayer1.Size = new System.Drawing.Size(17, 17);
            this.PictureBoxplayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxplayer1.TabIndex = 3;
            this.PictureBoxplayer1.TabStop = false;
            // 
            // ScorePlayer1
            // 
            this.ScorePlayer1.BackColor = System.Drawing.SystemColors.MenuText;
            this.ScorePlayer1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScorePlayer1.ForeColor = System.Drawing.Color.Red;
            this.ScorePlayer1.HideSelection = false;
            this.ScorePlayer1.Location = new System.Drawing.Point(81, 72);
            this.ScorePlayer1.Name = "ScorePlayer1";
            this.ScorePlayer1.ReadOnly = true;
            this.ScorePlayer1.Size = new System.Drawing.Size(76, 24);
            this.ScorePlayer1.TabIndex = 0;
            this.ScorePlayer1.Text = "0";
            this.ScorePlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScorePlayer1.TextChanged += new System.EventHandler(this.ScorePlayer1_TextChanged);
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score1.ForeColor = System.Drawing.Color.White;
            this.Score1.Location = new System.Drawing.Point(11, 72);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(68, 17);
            this.Score1.TabIndex = 1;
            this.Score1.Text = "Score:";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player1.ForeColor = System.Drawing.Color.White;
            this.Player1.Location = new System.Drawing.Point(28, 32);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(88, 17);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player 1";
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PictureBoxplayer2);
            this.panel2.Controls.Add(this.ScorePlayer2);
            this.panel2.Controls.Add(this.Score2);
            this.panel2.Controls.Add(this.Player2);
            this.panel2.Location = new System.Drawing.Point(180, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 120);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PictureBoxplayer2
            // 
            this.PictureBoxplayer2.Location = new System.Drawing.Point(11, 32);
            this.PictureBoxplayer2.Name = "PictureBoxplayer2";
            this.PictureBoxplayer2.Size = new System.Drawing.Size(17, 17);
            this.PictureBoxplayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxplayer2.TabIndex = 4;
            this.PictureBoxplayer2.TabStop = false;
            // 
            // ScorePlayer2
            // 
            this.ScorePlayer2.BackColor = System.Drawing.SystemColors.MenuText;
            this.ScorePlayer2.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScorePlayer2.ForeColor = System.Drawing.Color.Red;
            this.ScorePlayer2.HideSelection = false;
            this.ScorePlayer2.Location = new System.Drawing.Point(81, 72);
            this.ScorePlayer2.Name = "ScorePlayer2";
            this.ScorePlayer2.ReadOnly = true;
            this.ScorePlayer2.Size = new System.Drawing.Size(76, 24);
            this.ScorePlayer2.TabIndex = 3;
            this.ScorePlayer2.Text = "0";
            this.ScorePlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScorePlayer2.TextChanged += new System.EventHandler(this.ScorePlayer2_TextChanged);
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Score2.ForeColor = System.Drawing.Color.White;
            this.Score2.Location = new System.Drawing.Point(11, 72);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(68, 17);
            this.Score2.TabIndex = 1;
            this.Score2.Text = "Score:";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player2.ForeColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(28, 32);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(88, 17);
            this.Player2.TabIndex = 0;
            this.Player2.Text = "Player 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(515, 422);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "gameForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxplayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxplayer2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Score1;
        private Label Player1;
        private Panel panel2;
        private Label Score2;
        private Label Player2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem gameRulesToolStripMenuItem;
        public TextBox ScorePlayer1;
        public TextBox ScorePlayer2;
        public PictureBox PictureBoxplayer1;
        public PictureBox PictureBoxplayer2;
    }
}
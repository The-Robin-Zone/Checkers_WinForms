namespace CheckersWindows
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player1 = new System.Windows.Forms.Label();
            this.CurrentScore1 = new System.Windows.Forms.Label();
            this.TotalScore1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalScore2 = new System.Windows.Forms.Label();
            this.CurrentScore2 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TotalScore1);
            this.panel1.Controls.Add(this.CurrentScore1);
            this.panel1.Controls.Add(this.Player1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 133);
            this.panel1.TabIndex = 0;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(26, 20);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(64, 20);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player 1:";
            // 
            // CurrentScore1
            // 
            this.CurrentScore1.AutoSize = true;
            this.CurrentScore1.Location = new System.Drawing.Point(26, 53);
            this.CurrentScore1.Name = "CurrentScore1";
            this.CurrentScore1.Size = new System.Drawing.Size(101, 20);
            this.CurrentScore1.TabIndex = 1;
            this.CurrentScore1.Text = "Current Score:";
            // 
            // TotalScore1
            // 
            this.TotalScore1.AutoSize = true;
            this.TotalScore1.Location = new System.Drawing.Point(26, 92);
            this.TotalScore1.Name = "TotalScore1";
            this.TotalScore1.Size = new System.Drawing.Size(86, 20);
            this.TotalScore1.TabIndex = 2;
            this.TotalScore1.Text = "Total Score:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TotalScore2);
            this.panel2.Controls.Add(this.CurrentScore2);
            this.panel2.Controls.Add(this.Player2);
            this.panel2.Location = new System.Drawing.Point(544, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 133);
            this.panel2.TabIndex = 1;
            // 
            // TotalScore2
            // 
            this.TotalScore2.AutoSize = true;
            this.TotalScore2.Location = new System.Drawing.Point(26, 92);
            this.TotalScore2.Name = "TotalScore2";
            this.TotalScore2.Size = new System.Drawing.Size(86, 20);
            this.TotalScore2.TabIndex = 2;
            this.TotalScore2.Text = "Total Score:";
            // 
            // CurrentScore2
            // 
            this.CurrentScore2.AutoSize = true;
            this.CurrentScore2.Location = new System.Drawing.Point(26, 53);
            this.CurrentScore2.Name = "CurrentScore2";
            this.CurrentScore2.Size = new System.Drawing.Size(101, 20);
            this.CurrentScore2.TabIndex = 1;
            this.CurrentScore2.Text = "Current Score:";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(26, 20);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(64, 20);
            this.Player2.TabIndex = 0;
            this.Player2.Text = "Player 2:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(859, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label TotalScore1;
        private Label CurrentScore1;
        private Label Player1;
        private Panel panel2;
        private Label TotalScore2;
        private Label CurrentScore2;
        private Label Player2;
    }
}
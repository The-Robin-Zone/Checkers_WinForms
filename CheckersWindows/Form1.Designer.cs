namespace CheckersWindows
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player2checkBox = new System.Windows.Forms.CheckBox();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Size:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(23, 66);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(63, 24);
            this.radio6.TabIndex = 1;
            this.radio6.TabStop = true;
            this.radio6.Text = "6 X 6";
            this.radio6.UseVisualStyleBackColor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Location = new System.Drawing.Point(121, 66);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(63, 24);
            this.radio8.TabIndex = 2;
            this.radio8.TabStop = true;
            this.radio8.Text = "8 X 8";
            this.radio8.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Location = new System.Drawing.Point(215, 66);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(79, 24);
            this.radio10.TabIndex = 3;
            this.radio10.TabStop = true;
            this.radio10.Text = "10 X 10";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Players:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player 1:";
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(146, 159);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(125, 27);
            this.Player1.TabIndex = 7;
            this.Player1.TextChanged += new System.EventHandler(this.Player1_TextChanged);
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(146, 211);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(125, 27);
            this.Player2.TabIndex = 8;
            this.Player2.TextChanged += new System.EventHandler(this.Player2_TextChanged);
            // 
            // Player2checkBox
            // 
            this.Player2checkBox.AutoSize = true;
            this.Player2checkBox.Location = new System.Drawing.Point(23, 211);
            this.Player2checkBox.Name = "Player2checkBox";
            this.Player2checkBox.Size = new System.Drawing.Size(86, 24);
            this.Player2checkBox.TabIndex = 9;
            this.Player2checkBox.Text = "Player 2:";
            this.Player2checkBox.UseVisualStyleBackColor = true;
            this.Player2checkBox.CheckedChanged += new System.EventHandler(this.Player2checkBox_CheckedChanged);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(177, 269);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(94, 29);
            this.Done.TabIndex = 10;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Player2checkBox);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radio10);
            this.Controls.Add(this.radio8);
            this.Controls.Add(this.radio6);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radio6;
        private RadioButton radio8;
        private RadioButton radio10;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Player1;
        private TextBox Player2;
        private CheckBox Player2checkBox;
        private Button Done;
    }
}
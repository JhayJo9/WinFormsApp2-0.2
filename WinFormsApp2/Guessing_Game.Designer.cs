namespace WinFormsApp2
{
    partial class Guessing_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guessing_Game));
            label1 = new System.Windows.Forms.Label();
            txtEnterNumber = new System.Windows.Forms.TextBox();
            checkbutton = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            lblguess = new System.Windows.Forms.Label();
            lblGuessed = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(32, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter a number  between 1 and 100";
            // 
            // txtEnterNumber
            // 
            txtEnterNumber.Location = new System.Drawing.Point(151, 102);
            txtEnterNumber.Name = "txtEnterNumber";
            txtEnterNumber.PlaceholderText = "Guess number";
            txtEnterNumber.Size = new System.Drawing.Size(125, 27);
            txtEnterNumber.TabIndex = 1;
            txtEnterNumber.TextChanged += textBox1_TextChanged;
            // 
            // checkbutton
            // 
            checkbutton.BackgroundImage = (System.Drawing.Image)resources.GetObject("checkbutton.BackgroundImage");
            checkbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            checkbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkbutton.ForeColor = System.Drawing.Color.White;
            checkbutton.Location = new System.Drawing.Point(48, 156);
            checkbutton.Name = "checkbutton";
            checkbutton.Size = new System.Drawing.Size(94, 29);
            checkbutton.TabIndex = 2;
            checkbutton.Text = "CHECK";
            checkbutton.UseVisualStyleBackColor = true;
            checkbutton.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(278, 156);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblguess
            // 
            lblguess.AutoSize = true;
            lblguess.BackColor = System.Drawing.SystemColors.ControlDark;
            lblguess.Location = new System.Drawing.Point(140, 133);
            lblguess.Name = "lblguess";
            lblguess.Size = new System.Drawing.Size(0, 20);
            lblguess.TabIndex = 4;
            // 
            // lblGuessed
            // 
            lblGuessed.AutoSize = true;
            lblGuessed.Location = new System.Drawing.Point(138, 133);
            lblGuessed.Name = "lblGuessed";
            lblGuessed.Size = new System.Drawing.Size(0, 20);
            lblGuessed.TabIndex = 5;
            // 
            // Guessing_Game
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(425, 236);
            Controls.Add(lblGuessed);
            Controls.Add(lblguess);
            Controls.Add(button2);
            Controls.Add(checkbutton);
            Controls.Add(txtEnterNumber);
            Controls.Add(label1);
            Name = "Guessing_Game";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Guessing_Game";
            Load += Guessing_Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblguess;
        private System.Windows.Forms.Label lblGuessed;
    }
}
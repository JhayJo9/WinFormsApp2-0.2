namespace WinFormsApp2
{
    partial class flappy_bird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flappy_bird));
            pipetop = new System.Windows.Forms.PictureBox();
            pipe_bottom = new System.Windows.Forms.PictureBox();
            bird_ko = new System.Windows.Forms.PictureBox();
            gametimer = new System.Windows.Forms.Timer(components);
            ground = new System.Windows.Forms.PictureBox();
            score_txt = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pipetop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird_ko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipetop
            // 
            pipetop.BackgroundImage = (System.Drawing.Image)resources.GetObject("pipetop.BackgroundImage");
            pipetop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pipetop.ErrorImage = null;
            pipetop.Location = new System.Drawing.Point(473, 0);
            pipetop.Name = "pipetop";
            pipetop.Size = new System.Drawing.Size(125, 117);
            pipetop.TabIndex = 0;
            pipetop.TabStop = false;
            // 
            // pipe_bottom
            // 
            pipe_bottom.BackgroundImage = (System.Drawing.Image)resources.GetObject("pipe_bottom.BackgroundImage");
            pipe_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pipe_bottom.Location = new System.Drawing.Point(363, 460);
            pipe_bottom.Name = "pipe_bottom";
            pipe_bottom.Size = new System.Drawing.Size(125, 105);
            pipe_bottom.TabIndex = 2;
            pipe_bottom.TabStop = false;
            // 
            // bird_ko
            // 
            bird_ko.BackColor = System.Drawing.Color.Transparent;
            bird_ko.BackgroundImage = (System.Drawing.Image)resources.GetObject("bird_ko.BackgroundImage");
            bird_ko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bird_ko.Location = new System.Drawing.Point(117, 222);
            bird_ko.Name = "bird_ko";
            bird_ko.Size = new System.Drawing.Size(96, 72);
            bird_ko.TabIndex = 3;
            bird_ko.TabStop = false;
            bird_ko.Click += bird_ko_Click;
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gametimeevent;
            // 
            // ground
            // 
            ground.BackgroundImage = (System.Drawing.Image)resources.GetObject("ground.BackgroundImage");
            ground.Location = new System.Drawing.Point(-32, 562);
            ground.Name = "ground";
            ground.Size = new System.Drawing.Size(806, 112);
            ground.TabIndex = 4;
            ground.TabStop = false;
            // 
            // score_txt
            // 
            score_txt.AutoSize = true;
            score_txt.BackColor = System.Drawing.Color.Transparent;
            score_txt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score_txt.Location = new System.Drawing.Point(36, 22);
            score_txt.Name = "score_txt";
            score_txt.Size = new System.Drawing.Size(111, 41);
            score_txt.TabIndex = 5;
            score_txt.Text = "Score: ";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(307, 305);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click_1;
            // 
            // flappy_bird
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(687, 658);
            Controls.Add(button1);
            Controls.Add(bird_ko);
            Controls.Add(ground);
            Controls.Add(pipe_bottom);
            Controls.Add(pipetop);
            Controls.Add(score_txt);
            Name = "flappy_bird";
            Text = "flappy_bird";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipetop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird_ko).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipe_bottom;
        private System.Windows.Forms.PictureBox bird_ko;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label score_txt;
        private System.Windows.Forms.Button button1;
    }
}
namespace Square_Chaser
{
    partial class squareChaser
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.plr1ScoreLabel = new System.Windows.Forms.Label();
            this.plr2ScoreLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.wasd = new System.Windows.Forms.Label();
            this.updownleftright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // plr1ScoreLabel
            // 
            this.plr1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plr1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.plr1ScoreLabel.Location = new System.Drawing.Point(16, 16);
            this.plr1ScoreLabel.Name = "plr1ScoreLabel";
            this.plr1ScoreLabel.Size = new System.Drawing.Size(200, 32);
            this.plr1ScoreLabel.TabIndex = 0;
            this.plr1ScoreLabel.Text = "Player 1 Score:";
            this.plr1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plr2ScoreLabel
            // 
            this.plr2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plr2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.plr2ScoreLabel.Location = new System.Drawing.Point(376, 16);
            this.plr2ScoreLabel.Name = "plr2ScoreLabel";
            this.plr2ScoreLabel.Size = new System.Drawing.Size(200, 32);
            this.plr2ScoreLabel.TabIndex = 1;
            this.plr2ScoreLabel.Text = "Player 2 Score:";
            this.plr2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(224, 16);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(144, 32);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wasd
            // 
            this.wasd.AutoSize = true;
            this.wasd.Location = new System.Drawing.Point(32, 224);
            this.wasd.Name = "wasd";
            this.wasd.Size = new System.Drawing.Size(35, 13);
            this.wasd.TabIndex = 3;
            this.wasd.Text = "label1";
            // 
            // updownleftright
            // 
            this.updownleftright.AutoSize = true;
            this.updownleftright.Location = new System.Drawing.Point(275, 274);
            this.updownleftright.Name = "updownleftright";
            this.updownleftright.Size = new System.Drawing.Size(0, 13);
            this.updownleftright.TabIndex = 4;
            // 
            // squareChaser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.updownleftright);
            this.Controls.Add(this.wasd);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.plr2ScoreLabel);
            this.Controls.Add(this.plr1ScoreLabel);
            this.DoubleBuffered = true;
            this.Name = "squareChaser";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.squareChaser_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.squareChaser_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.squareChaser_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label plr1ScoreLabel;
        private System.Windows.Forms.Label plr2ScoreLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label wasd;
        private System.Windows.Forms.Label updownleftright;
    }
}


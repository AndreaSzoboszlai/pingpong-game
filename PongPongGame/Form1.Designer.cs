namespace PongPongGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player2Score = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(978, 207);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(18, 153);
            this.Player2.TabIndex = 0;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(34, 207);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(18, 153);
            this.Player1.TabIndex = 1;
            this.Player1.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.White;
            this.Ball.Location = new System.Drawing.Point(435, 356);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.Color.Transparent;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player2Score.ForeColor = System.Drawing.Color.White;
            this.Player2Score.Location = new System.Drawing.Point(756, 37);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(49, 32);
            this.Player2Score.TabIndex = 3;
            this.Player2Score.Text = "00";
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.Color.Transparent;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1Score.ForeColor = System.Drawing.Color.White;
            this.Player1Score.Location = new System.Drawing.Point(272, 647);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(49, 32);
            this.Player1Score.TabIndex = 4;
            this.Player1Score.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player1 Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(573, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player2 Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PingPong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


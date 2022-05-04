namespace ArcadeGames {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.snake = new System.Windows.Forms.Panel();
            this.snakeDescLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snakeBtn = new System.Windows.Forms.Button();
            this.pong = new System.Windows.Forms.Panel();
            this.pongDescLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pongBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.snake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Black;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(186, 27);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(618, 62);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Arcade Games";
            // 
            // snake
            // 
            this.snake.BackColor = System.Drawing.Color.White;
            this.snake.Controls.Add(this.snakeDescLbl);
            this.snake.Controls.Add(this.pictureBox1);
            this.snake.Controls.Add(this.snakeBtn);
            this.snake.Location = new System.Drawing.Point(22, 86);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(403, 417);
            this.snake.TabIndex = 1;
            // 
            // snakeDescLbl
            // 
            this.snakeDescLbl.AutoSize = true;
            this.snakeDescLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.snakeDescLbl.Location = new System.Drawing.Point(22, 173);
            this.snakeDescLbl.Name = "snakeDescLbl";
            this.snakeDescLbl.Size = new System.Drawing.Size(413, 84);
            this.snakeDescLbl.TabIndex = 3;
            this.snakeDescLbl.Text = "Grow your snake by eating as many bits \r\nas you can without running into the wall" +
    "s \r\nor yourself!";
            this.snakeDescLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // snakeBtn
            // 
            this.snakeBtn.BackColor = System.Drawing.Color.Lime;
            this.snakeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.snakeBtn.Location = new System.Drawing.Point(147, 314);
            this.snakeBtn.Name = "snakeBtn";
            this.snakeBtn.Size = new System.Drawing.Size(98, 48);
            this.snakeBtn.TabIndex = 1;
            this.snakeBtn.Text = "Play";
            this.snakeBtn.UseVisualStyleBackColor = false;
            this.snakeBtn.Click += new System.EventHandler(this.PlaySnakeBtn);
            // 
            // pong
            // 
            this.pong.BackColor = System.Drawing.Color.White;
            this.pong.Controls.Add(this.pongDescLbl);
            this.pong.Controls.Add(this.pictureBox2);
            this.pong.Controls.Add(this.pongBtn);
            this.pong.Location = new System.Drawing.Point(447, 86);
            this.pong.Name = "pong";
            this.pong.Size = new System.Drawing.Size(403, 417);
            this.pong.TabIndex = 2;
            // 
            // pongDescLbl
            // 
            this.pongDescLbl.AutoSize = true;
            this.pongDescLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pongDescLbl.Location = new System.Drawing.Point(28, 173);
            this.pongDescLbl.Name = "pongDescLbl";
            this.pongDescLbl.Size = new System.Drawing.Size(419, 84);
            this.pongDescLbl.TabIndex = 4;
            this.pongDescLbl.Text = "Defeat your opponent in this simple tennis\r\nlike game by being the first player t" +
    "o gain \r\n10 points!";
            this.pongDescLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(54, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pongBtn
            // 
            this.pongBtn.BackColor = System.Drawing.Color.Lime;
            this.pongBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pongBtn.Location = new System.Drawing.Point(147, 314);
            this.pongBtn.Name = "pongBtn";
            this.pongBtn.Size = new System.Drawing.Size(98, 48);
            this.pongBtn.TabIndex = 2;
            this.pongBtn.Text = "Play";
            this.pongBtn.UseVisualStyleBackColor = false;
            this.pongBtn.Click += new System.EventHandler(this.PlayPongBtn);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(638, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitBtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArcadeGames.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(873, 683);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pong);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.welcomeLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Arcade Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.snake.ResumeLayout(false);
            this.snake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pong.ResumeLayout(false);
            this.pong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel snake;
        private System.Windows.Forms.Panel pong;
        private System.Windows.Forms.Button snakeBtn;
        private System.Windows.Forms.Button pongBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label snakeDescLbl;
        private System.Windows.Forms.Label pongDescLbl;
    }
}

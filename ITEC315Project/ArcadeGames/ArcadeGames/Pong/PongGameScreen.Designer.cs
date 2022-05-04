namespace ArcadeGames {
    partial class PongGameScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongGameScreen));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pongCanvas = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.centerLine = new System.Windows.Forms.PictureBox();
            this.scoreLbl1 = new System.Windows.Forms.Label();
            this.scoreLbl2 = new System.Windows.Forms.Label();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.resetPongBtn = new System.Windows.Forms.Button();
            this.backPongBtn = new System.Windows.Forms.Button();
            this.player1WinsLbl = new System.Windows.Forms.Label();
            this.player2WinsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pongCanvas
            // 
            this.pongCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(8)))));
            this.pongCanvas.Location = new System.Drawing.Point(29, 108);
            this.pongCanvas.Name = "pongCanvas";
            this.pongCanvas.Size = new System.Drawing.Size(1050, 612);
            this.pongCanvas.TabIndex = 7;
            this.pongCanvas.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.White;
            this.paddle2.Location = new System.Drawing.Point(1017, 294);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(18, 240);
            this.paddle2.TabIndex = 8;
            this.paddle2.TabStop = false;
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.White;
            this.paddle1.Location = new System.Drawing.Point(74, 294);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(18, 240);
            this.paddle1.TabIndex = 9;
            this.paddle1.TabStop = false;
            // 
            // centerLine
            // 
            this.centerLine.BackColor = System.Drawing.Color.White;
            this.centerLine.Location = new System.Drawing.Point(549, 108);
            this.centerLine.Name = "centerLine";
            this.centerLine.Size = new System.Drawing.Size(10, 612);
            this.centerLine.TabIndex = 10;
            this.centerLine.TabStop = false;
            // 
            // scoreLbl1
            // 
            this.scoreLbl1.AutoSize = true;
            this.scoreLbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(8)))));
            this.scoreLbl1.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl1.Location = new System.Drawing.Point(420, 108);
            this.scoreLbl1.Name = "scoreLbl1";
            this.scoreLbl1.Size = new System.Drawing.Size(88, 86);
            this.scoreLbl1.TabIndex = 11;
            this.scoreLbl1.Text = "0";
            // 
            // scoreLbl2
            // 
            this.scoreLbl2.AutoSize = true;
            this.scoreLbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(8)))));
            this.scoreLbl2.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLbl2.Location = new System.Drawing.Point(620, 109);
            this.scoreLbl2.Name = "scoreLbl2";
            this.scoreLbl2.Size = new System.Drawing.Size(88, 86);
            this.scoreLbl2.TabIndex = 12;
            this.scoreLbl2.Text = "0";
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.White;
            this.pongBall.Location = new System.Drawing.Point(539, 387);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(28, 28);
            this.pongBall.TabIndex = 13;
            this.pongBall.TabStop = false;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Interval = 20;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // resetPongBtn
            // 
            this.resetPongBtn.Location = new System.Drawing.Point(433, 21);
            this.resetPongBtn.Name = "resetPongBtn";
            this.resetPongBtn.Size = new System.Drawing.Size(114, 47);
            this.resetPongBtn.TabIndex = 16;
            this.resetPongBtn.Text = "Reset";
            this.resetPongBtn.UseVisualStyleBackColor = true;
            this.resetPongBtn.Click += new System.EventHandler(this.resetPongBtn_Click);
            // 
            // backPongBtn
            // 
            this.backPongBtn.Location = new System.Drawing.Point(561, 21);
            this.backPongBtn.Name = "backPongBtn";
            this.backPongBtn.Size = new System.Drawing.Size(114, 47);
            this.backPongBtn.TabIndex = 15;
            this.backPongBtn.Text = "Back";
            this.backPongBtn.UseVisualStyleBackColor = true;
            this.backPongBtn.Click += new System.EventHandler(this.backPongBtn_Click);
            // 
            // player1WinsLbl
            // 
            this.player1WinsLbl.AutoSize = true;
            this.player1WinsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(8)))));
            this.player1WinsLbl.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1WinsLbl.Location = new System.Drawing.Point(168, 212);
            this.player1WinsLbl.Name = "player1WinsLbl";
            this.player1WinsLbl.Size = new System.Drawing.Size(445, 172);
            this.player1WinsLbl.TabIndex = 17;
            this.player1WinsLbl.Text = "Player 1\r\nWins!";
            // 
            // player2WinsLbl
            // 
            this.player2WinsLbl.AutoSize = true;
            this.player2WinsLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(8)))));
            this.player2WinsLbl.Font = new System.Drawing.Font("OCR A Extended", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2WinsLbl.Location = new System.Drawing.Point(622, 212);
            this.player2WinsLbl.Name = "player2WinsLbl";
            this.player2WinsLbl.Size = new System.Drawing.Size(445, 172);
            this.player2WinsLbl.TabIndex = 18;
            this.player2WinsLbl.Text = "Player 2\r\nWins!";
            // 
            // PongGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1106, 743);
            this.Controls.Add(this.player2WinsLbl);
            this.Controls.Add(this.player1WinsLbl);
            this.Controls.Add(this.resetPongBtn);
            this.Controls.Add(this.backPongBtn);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.scoreLbl2);
            this.Controls.Add(this.scoreLbl1);
            this.Controls.Add(this.centerLine);
            this.Controls.Add(this.paddle1);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.pongCanvas);
            this.Controls.Add(this.pictureBox2);
            this.Name = "PongGameScreen";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongGameScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongGameScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pongCanvas;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox centerLine;
        private System.Windows.Forms.Label scoreLbl1;
        private System.Windows.Forms.Label scoreLbl2;
        private System.Windows.Forms.PictureBox pongBall;
        private System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Button resetPongBtn;
        private System.Windows.Forms.Button backPongBtn;
        private System.Windows.Forms.Label player1WinsLbl;
        private System.Windows.Forms.Label player2WinsLbl;
    }
}
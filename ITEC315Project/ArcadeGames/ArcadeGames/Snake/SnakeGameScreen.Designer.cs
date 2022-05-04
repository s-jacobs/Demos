namespace ArcadeGames {
    partial class SnakeGameScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGameScreen));
            this.snakeHeader = new System.Windows.Forms.PictureBox();
            this.snakeScoreLbl = new System.Windows.Forms.Label();
            this.startSnakeBtn = new System.Windows.Forms.Button();
            this.backSnakeBtn = new System.Windows.Forms.Button();
            this.snakeCanvas = new System.Windows.Forms.PictureBox();
            this.snakeTimer = new System.Windows.Forms.Timer(this.components);
            this.resetSnakeBtn = new System.Windows.Forms.Button();
            this.gameOverLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snakeHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeHeader
            // 
            this.snakeHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.snakeHeader.BackColor = System.Drawing.Color.Transparent;
            this.snakeHeader.Image = ((System.Drawing.Image)(resources.GetObject("snakeHeader.Image")));
            this.snakeHeader.Location = new System.Drawing.Point(32, 11);
            this.snakeHeader.Name = "snakeHeader";
            this.snakeHeader.Size = new System.Drawing.Size(227, 91);
            this.snakeHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snakeHeader.TabIndex = 1;
            this.snakeHeader.TabStop = false;
            // 
            // snakeScoreLbl
            // 
            this.snakeScoreLbl.AutoSize = true;
            this.snakeScoreLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.snakeScoreLbl.ForeColor = System.Drawing.Color.White;
            this.snakeScoreLbl.Location = new System.Drawing.Point(295, 45);
            this.snakeScoreLbl.Name = "snakeScoreLbl";
            this.snakeScoreLbl.Size = new System.Drawing.Size(105, 32);
            this.snakeScoreLbl.TabIndex = 3;
            this.snakeScoreLbl.Text = "Score:  0";
            // 
            // startSnakeBtn
            // 
            this.startSnakeBtn.Location = new System.Drawing.Point(447, 41);
            this.startSnakeBtn.Name = "startSnakeBtn";
            this.startSnakeBtn.Size = new System.Drawing.Size(114, 47);
            this.startSnakeBtn.TabIndex = 4;
            this.startSnakeBtn.Text = "Start";
            this.startSnakeBtn.UseVisualStyleBackColor = true;
            this.startSnakeBtn.Click += new System.EventHandler(this.StartSnakeGame);
            // 
            // backSnakeBtn
            // 
            this.backSnakeBtn.Location = new System.Drawing.Point(703, 41);
            this.backSnakeBtn.Name = "backSnakeBtn";
            this.backSnakeBtn.Size = new System.Drawing.Size(114, 47);
            this.backSnakeBtn.TabIndex = 5;
            this.backSnakeBtn.Text = "Back";
            this.backSnakeBtn.UseVisualStyleBackColor = true;
            this.backSnakeBtn.Click += new System.EventHandler(this.ExitSnake);
            // 
            // snakeCanvas
            // 
            this.snakeCanvas.BackColor = System.Drawing.Color.LimeGreen;
            this.snakeCanvas.Location = new System.Drawing.Point(32, 108);
            this.snakeCanvas.Name = "snakeCanvas";
            this.snakeCanvas.Size = new System.Drawing.Size(1051, 612);
            this.snakeCanvas.TabIndex = 6;
            this.snakeCanvas.TabStop = false;
            this.snakeCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeUpdatePictureBoxGraphics);
            // 
            // snakeTimer
            // 
            this.snakeTimer.Interval = 60;
            this.snakeTimer.Tick += new System.EventHandler(this.SnakeGameTimerEvent);
            // 
            // resetSnakeBtn
            // 
            this.resetSnakeBtn.Location = new System.Drawing.Point(575, 41);
            this.resetSnakeBtn.Name = "resetSnakeBtn";
            this.resetSnakeBtn.Size = new System.Drawing.Size(114, 47);
            this.resetSnakeBtn.TabIndex = 7;
            this.resetSnakeBtn.Text = "Reset";
            this.resetSnakeBtn.UseVisualStyleBackColor = true;
            this.resetSnakeBtn.Click += new System.EventHandler(this.ResetSnake);
            // 
            // gameOverLbl
            // 
            this.gameOverLbl.AutoSize = true;
            this.gameOverLbl.BackColor = System.Drawing.Color.LimeGreen;
            this.gameOverLbl.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLbl.Location = new System.Drawing.Point(464, 395);
            this.gameOverLbl.Name = "gameOverLbl";
            this.gameOverLbl.Size = new System.Drawing.Size(0, 60);
            this.gameOverLbl.TabIndex = 8;
            // 
            // SnakeGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1106, 743);
            this.Controls.Add(this.gameOverLbl);
            this.Controls.Add(this.resetSnakeBtn);
            this.Controls.Add(this.snakeCanvas);
            this.Controls.Add(this.backSnakeBtn);
            this.Controls.Add(this.startSnakeBtn);
            this.Controls.Add(this.snakeScoreLbl);
            this.Controls.Add(this.snakeHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnakeGameScreen";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.snakeHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snakeHeader;
        private System.Windows.Forms.Label snakeScoreLbl;
        private System.Windows.Forms.Button startSnakeBtn;
        private System.Windows.Forms.Button backSnakeBtn;
        private System.Windows.Forms.PictureBox snakeCanvas;
        private System.Windows.Forms.Timer snakeTimer;
        private System.Windows.Forms.Button resetSnakeBtn;
        private System.Windows.Forms.Label gameOverLbl;
    }
}
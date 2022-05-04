/* References:
 * https://www.youtube.com/watch?v=zK-nIsHM8XM
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeGames {
    public partial class PongGameScreen : Form {
        public PongGameScreen() {
            InitializeComponent();
            // set text to labels and buttons
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Users\serra\Desktop\GUI_315\Project\ProjTest\ArcadeGames\ArcadeGames\Fonts\VT323-Regular.ttf");


            foreach (Control c in this.Controls) {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }

            player1WinsLbl.Text = "";
            player2WinsLbl.Text = "";
            //bottomBoundary = ClientSize.Height - paddle1.Height;
            xMidPt = pongCanvas.Width / 2;
            yMidPt = (pongCanvas.Height / 2) +pongCanvas.Top;

        }

        int ballXCoord = 7;
        int ballYCoord = 7;

        int player1Score = 0;
        int player2Score = 0;

        int bottomBoundary = 690;
        int bottomBoundaryPaddles = 480;
        int topBoundary = 108;
        int leftBoundary = 29;
        int rightBoundary = 1050 + 29;

        int xMidPt;
        int yMidPt;

        bool p1DetectUp;
        bool p1DetectDown;

        bool p2DetectUp;
        bool p2DetectDown;
        bool gamePaused = false;
        

        private void pongTimer_Tick(object sender, EventArgs e) {
            //int newBallSpot = yMidPt;

            resetPongBtn.Enabled = false;
            backPongBtn.Enabled = false;

            //move ball
            pongBall.Left -= ballXCoord;
            pongBall.Top -= ballYCoord;


            //move paddles
            if(p1DetectUp == true && paddle1.Top > topBoundary) {  paddle1.Top -= 10;  }
            if(p1DetectDown == true && paddle1.Top < bottomBoundaryPaddles) {  paddle1.Top += 10;  }

            if (p2DetectUp == true && paddle2.Top > topBoundary) {  paddle2.Top -= 10;  }
            if (p2DetectDown == true && paddle2.Top < bottomBoundaryPaddles) {  paddle2.Top += 10;  }

            //check top and bottom bounds for ball
            if (pongBall.Top < topBoundary || pongBall.Top > bottomBoundary) {
                ballYCoord = -ballYCoord;
            }

            //check if ball hit paddle
            if(pongBall.Bounds.IntersectsWith(paddle1.Bounds) || pongBall.Bounds.IntersectsWith(paddle2.Bounds)) {
                ballXCoord = -ballXCoord;
            }

            //check if player 1 scored
            if(pongBall.Left + pongBall.Width > rightBoundary) {
                pongBall.Left = xMidPt;    pongBall.Top = yMidPt;
                ballXCoord = -ballXCoord;  player1Score++;
                scoreLbl1.Text = player1Score.ToString();
            }

            // check if player 2 scored
            if(pongBall.Left < leftBoundary) {
                pongBall.Left = xMidPt;    pongBall.Top = yMidPt;
                ballXCoord = -ballXCoord;  player2Score++;
                scoreLbl2.Text = player2Score.ToString();
            }

            if(player1Score >= 10) {  player1WinsLbl.Text = "Player 1\nWins!";  gameOver();  }
            if(player2Score >= 10) {  player2WinsLbl.Text = "Player 2\nWins!";  gameOver();  }
        }

        private void gameOver() {
            pongTimer.Stop();
            pongBall.Left = xMidPt;
            pongBall.Top = yMidPt;
            
            centerLine.Left = 549;
            centerLine.Top = 108;

            paddle1.Left = 74;
            paddle1.Top = 294;

            paddle2.Left = 1017;
            paddle2.Top = 294;

            resetPongBtn.Enabled = true;
            backPongBtn.Enabled = true;
        }

        private void Pause() {
            pongTimer.Stop();
            MessageBox.Show("Game Paused:  Click ok to continue.");
        }

        private void Unpause() {
            pongTimer.Start();
        }

        private void backPongBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void resetPongBtn_Click(object sender, EventArgs e) {
            pongTimer.Stop();
            player1Score = 0;
            player2Score = 0;

            scoreLbl1.Text = "0";
            scoreLbl2.Text = "0";

            pongBall.Top = 387;
            pongBall.Left = 539;

            var t = Task.Delay(3000);
            t.Wait();
            pongTimer.Start();
        }

        private void PongGameScreen_KeyUp(object sender, KeyEventArgs e) {
            //up arrow stop pressed
            if (e.KeyCode == Keys.Up) {
                p2DetectUp = false;
            }
            //down arrow stop pressed
            if (e.KeyCode == Keys.Down) {
                p2DetectDown = false;
            }
            //w key stop pressed
            if (e.KeyCode == Keys.W) {
                p1DetectUp = false;
            }
            //s key stop pressed
            if (e.KeyCode == Keys.S) {
                p1DetectDown = false;
            }
        }

        private void PongGameScreen_KeyDown(object sender, KeyEventArgs e) {
            //up arrow pressed
            if(e.KeyCode == Keys.Up) {
                p2DetectUp = true;
            }
            //down arrow pressed
            if(e.KeyCode == Keys.Down) {
                p2DetectDown = true;
            }
            //w key pressed
            if(e.KeyCode == Keys.W) {
                p1DetectUp = true;
            }
            //s key pressed
            if (e.KeyCode == Keys.S) {
                p1DetectDown = true;
            }
            //Esc key pressed (pause game)
            if (e.KeyCode == Keys.Escape) {
                Pause();
                gamePaused = true;
            }
            if (e.KeyCode == Keys.Escape && gamePaused == true) {
                Unpause();
                gamePaused = false;
            }
        }

    }
}

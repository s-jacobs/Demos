/*References:
 * https://www.youtube.com/watch?v=TzaCn1ZPalI&t=2683s
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
    public partial class SnakeGameScreen : Form {
        private List<Circle> snake = new List<Circle>();
        private Circle food = new Circle();

        //max width and height snake can travel
        int maxWidth;
        int maxHeight;

        int score;

        Random rand = new Random();
        bool goLeft, goRight, goUp, goDown, gamePaused;

        public SnakeGameScreen() {
            InitializeComponent();
            new SnakeSettings();
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Users\serra\Desktop\GUI_315\Project\ProjTest\ArcadeGames\ArcadeGames\Fonts\VT323-Regular.ttf");

            gameOverLbl.Font = new Font(pfc.Families[0], gameOverLbl.Font.Size);

            foreach (Control c in this.Controls) {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);

            }
        }
        private void ExitSnake(object sender, EventArgs e) {
            this.Close();
        }

        private void KeyIsDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Left && SnakeSettings.directions != "right") {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && SnakeSettings.directions != "left") {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && SnakeSettings.directions != "down") {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && SnakeSettings.directions != "up") {
                goDown = true;
            }
            if(e.KeyCode == Keys.Escape) {
                Pause();
                gamePaused = true;
            }
            if(e.KeyCode == Keys.Escape && gamePaused == true) {
                Unpause();
                gamePaused=false;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right) {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up) {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down) {
                goDown = false;
            }
        }

        private void StartSnakeGame(object sender, EventArgs e) {
            Restart();

            //reset buttons
            startSnakeBtn.Enabled = false;
            //resetSnakeBtn.TabStop = false;
            resetSnakeBtn.Enabled = false;
            backSnakeBtn.Enabled = false;

            gamePaused = false;

            snakeTimer.Start();
        }

        private void SnakeGameTimerEvent(object sender, EventArgs e) {
            //directions
            if(goLeft) { SnakeSettings.directions = "left";
            }  if(goRight) { SnakeSettings.directions = "right";
            }  if(goDown) { SnakeSettings.directions = "down";
            }  if(goUp) { SnakeSettings.directions = "up";  }

            for (int i = snake.Count - 1; i >= 0; i--) {
                if (i == 0) {//find the snake head
                    switch (SnakeSettings.directions) {
                        case "left":
                            snake[i].x--; break;
                        case "right":
                            snake[i].x++; break;
                        case "down":
                            snake[i].y++; break;
                        case "up":
                            snake[i].y--; break;

                    }//end switch

                    /*if (snake[i].x < 0) {  snake[i].x = maxWidth;  }
                    if (snake[i].x > maxWidth) {  snake[i].x = 0;  }
                    if (snake[i].y < 0) {  snake[i].y = maxHeight;  }
                    if (snake[i].y > maxHeight) { snake[i].y = 0; }*/
                    if (snake[i].x < 0) { SnakeGameOver(); }
                    if (snake[i].x > maxWidth) { SnakeGameOver(); }
                    if (snake[i].y < 0) { SnakeGameOver(); }
                    if (snake[i].y > maxHeight) { SnakeGameOver(); }
                    if (snake[i].x == food.x && snake[i].y == food.y) {
                        EatFood();
                    }

                    for(int j = 1; j < snake.Count; j++) {
                        if(snake[i].x == snake[j].x && snake[i].y == snake[j].y) {
                            SnakeGameOver();
                        }
                    }

                } else {
                        snake[i].x = snake[i - 1].x;
                        snake[i].y = snake[i - 1].y;
                }
            }//end backwards for

                //clear canvas with each tick so images can be redrawn
                snakeCanvas.Invalidate();
        }

        private void SnakeUpdatePictureBoxGraphics(object sender, PaintEventArgs e) {
            //link PaintEvent from args to Graphics canvas
            Graphics g = e.Graphics;
            Brush snakeColor;

            for(int i = 0; i < snake.Count; i++) {
                if(i == 0) {
                    snakeColor = Brushes.Black;
                } else {
                    snakeColor = Brushes.DarkSlateBlue;
                }

                g.FillEllipse(snakeColor, 
                              new Rectangle(
                                snake[i].x * SnakeSettings.width,
                                snake[i].y * SnakeSettings.height,
                                SnakeSettings.width, SnakeSettings.height
                    ));
            }

            g.FillEllipse(Brushes.Red, new Rectangle(
                    food.x * SnakeSettings.width,
                    food.y * SnakeSettings.height,
                    SnakeSettings.width, SnakeSettings.height
                ));
        }


        private void EatFood() {
            score += 1;
            snakeScoreLbl.Text = "Score: " + score.ToString();

            //add to body of snake (last index)
            Circle body = new Circle {
                x = snake[snake.Count - 1].x,
                y = snake[snake.Count - 1].y
            };

            snake.Add(body);

            //add new food
            food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxHeight) };

        }

        private void SnakeGameOver() {
            snakeTimer.Stop();
            startSnakeBtn.Enabled = true;
            resetSnakeBtn.Enabled = true;
            backSnakeBtn.Enabled = true;
            gameOverLbl.Text = "Game Over";
        }

        private void ResetSnake(object sender, EventArgs e) {
            Restart();
        }

        private void Pause() {
            snakeTimer.Stop();
            MessageBox.Show("Game Paused:  Click ok to continue.");
        }

        private void Unpause() {
            snakeTimer.Start();
        }

        private void Restart() {
            maxWidth = snakeCanvas.Width / SnakeSettings.width - 1;
            maxHeight = snakeCanvas.Height / SnakeSettings.height - 1;
 
            //clear snake list
            snake.Clear();

            //reset score
            score = 0;
            snakeScoreLbl.Text = "Score: " + score;

            //create head of snake
            Circle head = new Circle { x=10,y=5 };
            snake.Add(head);
            for (int i = 0; i < 10; i++) {
                Circle body = new Circle();
                snake.Add(body);
            }

            food = new Circle { x=rand.Next(2, maxWidth), y=rand.Next(2, maxHeight) };

            snakeCanvas.Invalidate();
            gameOverLbl.Text = "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ArcadeGames {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"C:\Users\serra\Desktop\GUI_315\Project\ProjTest\ArcadeGames\ArcadeGames\Fonts\VT323-Regular.ttf");

            snakeBtn.Font = new Font(pfc.Families[0], snakeBtn.Font.Size);
            pongBtn.Font = new Font(pfc.Families[0], pongBtn.Font.Size);

            snakeDescLbl.Font = new Font(pfc.Families[0], snakeDescLbl.Font.Size);
            pongDescLbl.Font = new Font(pfc.Families[0], pongDescLbl.Font.Size);

            foreach (Control c in this.Controls) {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }
        }

        private void PlaySnakeBtn(object sender, EventArgs e) {
            
            SnakeGameScreen snakeGameScreen = new SnakeGameScreen();
            snakeGameScreen.Show();
        }

        private void PlayPongBtn(object sender, EventArgs e) {
            PongGameScreen pongGameScreen = new PongGameScreen();
            pongGameScreen.Show();
        }

        private void ExitBtn(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void snakeDescLbl_Click(object sender, EventArgs e) {

        }
    }
}

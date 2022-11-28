using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Square_Chaser
{
    public partial class squareChaser : Form
    {
        
        
        Rectangle barrier = new Rectangle(50,50,500,450);
        Rectangle edgeRectangle = new Rectangle(70, 70, 460, 410);
        Rectangle player1 = new Rectangle(100, 280, 20, 20);
        Rectangle player2 = new Rectangle(480, 280, 20, 20);
        Rectangle powerUp;
        Rectangle scoreBlock;
        Random randSpawn = new Random();
        
        
        SoundPlayer coinCollect1 = new SoundPlayer(Properties.Resources._341695__projectsu012__coins_1);
        SoundPlayer coinCollect2 = new SoundPlayer(Properties.Resources._336932__the_sacha_rush__coin5);
        SoundPlayer applause = new SoundPlayer(Properties.Resources._277020__sandermotions__applause_3);
        

        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush lightBlueBrush = new SolidBrush(Color.CadetBlue);

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        int player1Speed = 4;
        int player2Speed = 4;
        int player1Score = 0;
        int player2Score = 0;

        int playerRicohetX = -6;
        int playerRicohetY = 6;

        public squareChaser()
        {
            InitializeComponent();
            //spawnLocation = randSpawn.Next(0,599);
            powerUp = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 5,5);
            scoreBlock = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 15, 15);
        }

        private void squareChaser_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;

                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }

        }

        private void squareChaser_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, barrier);
            e.Graphics.FillRectangle(blackBrush, edgeRectangle);
            e.Graphics.FillRectangle(whiteBrush, player1);
            e.Graphics.FillRectangle(whiteBrush, player2);
            e.Graphics.FillRectangle(orangeBrush,powerUp);
            e.Graphics.FillRectangle(lightBlueBrush, scoreBlock);
        }

        private void squareChaser_KeyUp(object sender, KeyEventArgs e)
        {

            

            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;

                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)


        {

            /*if (player1.IntersectsWith(player2) && player1Speed > player2Speed)
            {
                for (int i = 0; i < 10; i++)
                {
                    player2.X -= playerRicohetX;
                    Thread.Sleep(100);
                    this.Refresh();
                }
                
            }*/

            //move player
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }
            
            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Height - player1.Width)
            {
                player1.X += player1Speed;
            }

            //move player 2
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }

            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            if (rightArrowDown == true && player2.X < this.Height - player2.Width)
            {
                player2.X += player2Speed;
            }

            //check wall collisions
            if (player1.X < 70 && aDown == true)
            {
                player1.X = 71;
            }
            if (player1.Y < 70 && wDown == true)
            {
                player1.Y = 71;
            }
            if (player1.X > 510 && dDown == true)
            {
                player1.X = 509;
            }
            if (player1.Y > 460 && sDown == true)
            {
                player1.Y = 459;
            }

            if (player2.X < 70 && leftArrowDown == true)
            {
                player2.X = 71;
            }
            if (player2.Y < 70 && upArrowDown == true)
            {
                player2.Y = 71;
            }
            if (player2.X > 510 && rightArrowDown == true)
            {
                player2.X = 509;
            }
            if (player2.Y > 460 && downArrowDown == true)
            {
                player2.Y = 459;
            }

            //collision with power up
            if (player1.IntersectsWith(powerUp))
            {
                powerUp = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 5, 5);
                player1Speed++;
                coinCollect1.Play();
            }

            if (player2.IntersectsWith(powerUp))
            {
                powerUp = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 5, 5);
                player2Speed++;
                coinCollect1.Play();
            }

            //collision with score block
            if (player1.IntersectsWith(scoreBlock) && player1Score < 5)
            {
                scoreBlock = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 15, 15);
                player1Score++;
                plr1ScoreLabel.Text = $"Player 1 Score: {player1Score}";
                coinCollect2.Play();

                if (player1Score == 5)
                {
                    player1Speed = 0;
                    player2Speed = 0;
                    outputLabel.Text = "Player 1 wins";
                    applause.Play();

                }
            }

            if (player2.IntersectsWith(scoreBlock) && player2Score < 5)
            {
                scoreBlock = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 15, 15);
                player2Score++;
                plr2ScoreLabel.Text = $"Player 2 Score: {player2Score}";
                coinCollect2.Play();

                if (player2Score == 5)
                {
                    player1Speed = 0;
                    player2Speed = 0;
                    outputLabel.Text = "Player 2 wins";
                    applause.Play();
                }
            }

            

            

            Refresh();
        }

    }
}

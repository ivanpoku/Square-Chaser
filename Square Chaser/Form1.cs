using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Chaser
{
    public partial class squareChaser : Form
    {
        
        
        Rectangle barrier = new Rectangle(50,50,500,450);
        Rectangle edgeRectangle = new Rectangle(70, 70, 460, 410);
        Rectangle player1 = new Rectangle(100, 280, 20, 20);
        Rectangle powerUp;
        Rectangle scoreBlock;
        Random randSpawn = new Random();
        
        

        

        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        SolidBrush lightBlueBrush = new SolidBrush(Color.CadetBlue);

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        int playerSpeed = 4;
        int playerScore = 0;
        int killBlockAmount = 1;

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
            }

        }

        private void squareChaser_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, barrier);
            e.Graphics.FillRectangle(blackBrush, edgeRectangle);
            e.Graphics.FillRectangle(whiteBrush, player1);
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
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }
            
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X < this.Height - player1.Width)
            {
                player1.X += playerSpeed;
            }

            //check wall collisions
            if (player1.X < 70 && aDown == true)
            {
                player1.X = 71;
            }
            else if (player1.Y < 70 && wDown == true)
            {
                player1.Y = 71;
            }
            else if (player1.X > 510 && dDown == true)
            {
                player1.X = 509;
            }
            else if (player1.Y > 460 && sDown == true)
            {
                player1.Y = 459;
            }

            //collision with power up
            if (player1.IntersectsWith(powerUp))
            {
                powerUp = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 5, 5);
                playerSpeed++;
            }

            //collision with score block
            if (player1.IntersectsWith(scoreBlock))
            {
                scoreBlock = new Rectangle(randSpawn.Next(70, 470), randSpawn.Next(70, 470), 15, 15);
            }

            Refresh();
        }
    }
}

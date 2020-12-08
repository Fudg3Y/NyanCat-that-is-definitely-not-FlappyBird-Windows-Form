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

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\Nyan Cat [original].wav";
            sp.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeMiddle.Left -= pipeSpeed;
            scoreText.Text = "Score: "+ score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
                if (score % 10 == 0)
                {
                    pipeSpeed++;
                }
            }

            if (pipeMiddle.Left < -150)
            {
                pipeMiddle.Left = 800;
                score++;
                if (score % 10 == 0)
                {
                    pipeSpeed++;
                }
            }

            if (pipeTop.Left  < -150)
            {
                pipeTop.Left = 900;
                score++;
                if (score % 10 == 0)
                {
                    pipeSpeed++;
                }
            }

            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeMiddle.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Bounds.IntersectsWith(roof.Bounds))
            {
                endGame();
            }

            
            
            
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
 
            }

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;

            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game OVER !!!";
            restartButton.Visible = true;
            scoreText.Location = new Point(200, 418);
            scoreText.Font = new Font("Arial", 36, FontStyle.Bold);

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restart();           
        }
        private void restart()
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}

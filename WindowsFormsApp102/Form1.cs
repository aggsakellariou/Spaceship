using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Threading;

namespace WindowsFormsApp102
{
    public partial class Form1 : Form
    {

        List<PictureBox> bulletsS = new List<PictureBox>();
        List<PictureBox> bulletsU = new List<PictureBox>();
        List<int> ScoreList = new List<int>();

        Score score = new Score();
        int temScore = 0;

        Random r;
        SoundPlayer s;

        public Form1()
        {
            InitializeComponent();
        }
        //
        // spaceship
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            spaceship.ImageLocation = "spaceship_icon1.png";
            spaceship.SizeMode = PictureBoxSizeMode.StretchImage;
            spaceship.Size = new Size(85,85);
            ufo.ImageLocation = "ufo_icon.png";
            ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            ufo.Size = new Size(80,80);
            r = new Random();
            s = new SoundPlayer("invaderkilled.wav");

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("score.ser", FileMode.Open, FileAccess.Read);
            Score newScore = (Score)formatter.Deserialize(stream);
            stream.Close();

            score = newScore;
        }
        //
        // spaceship bullet
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox BulletS in bulletsS)
            {
                BulletS.Location = new Point(BulletS.Location.X, BulletS.Location.Y - 10);
                killEnemy(ufo.Location.X, ufo.Location.Y, bulletsS);
            }
        }
        //
        // score ufo
        //
        private void killEnemy(int ufoX, int ufoY, List<PictureBox> bulletsS)
        {
            foreach (PictureBox BulletS in bulletsS)
            {
                if ((BulletS.Location.X < ufoX + 75) && (BulletS.Location.X > ufoX - 10))
                {
                    if ((BulletS.Location.Y < ufoY + 70) && (BulletS.Location.Y > ufoY - 5))
                    {
                        BulletS.Location = new Point(BulletS.Location.X, BulletS.Location.Y + 10000);
                        temScore += 100;
                    }
                }
            }
        }
        //
        // spaceship moves
        //
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Left"))
            {
                spaceship.Location = new Point(spaceship.Location.X - 15, spaceship.Location.Y);
                spaceship.ImageLocation = "spaceship_icon_left.png";
            }
            else if (e.KeyCode.ToString().Equals("Right"))
            {
                spaceship.Location = new Point(spaceship.Location.X + 15, spaceship.Location.Y);
                spaceship.ImageLocation = "spaceship_icon_right.png";
            }
            else if (e.KeyCode.ToString().Equals("Up"))
            {
                spaceship.Location = new Point(spaceship.Location.X, spaceship.Location.Y - 15);
                spaceship.ImageLocation = "spaceship_icon1.png";
            }
            else if (e.KeyCode.ToString().Equals("Down"))
            {
                spaceship.Location = new Point(spaceship.Location.X, spaceship.Location.Y + 15);
                spaceship.ImageLocation = "spaceship_icon1.png";
            }
            else if (e.KeyCode.ToString().Equals("Space"))
            {
                createBulletS(spaceship.Location.X);
            }            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            spaceship.ImageLocation = "spaceship_icon1.png";
        }
        //
        // spaceship fire bullet
        //
        private void createBulletS(int spaceshipLocation)
        {
            PictureBox BulletS = new PictureBox
            {
                ImageLocation = "bullet_red_icon.png",
                Location = new Point(spaceshipLocation + 33, spaceship.Location.Y - 20),
                Size = new Size(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(BulletS);
            bulletsS.Add(BulletS);
            s.Play();
        }
        //
        // ufo
        //
        private void timer2_Tick(object sender, EventArgs e)
        {
            ufo.Location = new Point(r.Next(Width - ufo.Width), ufo.Location.Y);
            createBulletU(ufo.Location.X);
        }
        //
        // ufo fire bullet
        //
        private void createBulletU(int ufoLocation)
        {
            PictureBox BulletU = new PictureBox
            {
                ImageLocation = "bullet_red_icon.png",
                Location = new Point(ufoLocation + 31, ufo.Location.Y + 25),
                Size = new Size(20, 20),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(BulletU);
            bulletsU.Add(BulletU);
            s.Play();
        }
        //
        // ufo bullet
        //
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            foreach (PictureBox BulletU in bulletsU)
            {
                BulletU.Location = new Point(BulletU.Location.X, BulletU.Location.Y + 10);
                killPlayer(spaceship.Location.X, spaceship.Location.Y, bulletsU);
            }
        }
        //
        // score spaceship
        //
        private void killPlayer(int spaceshipX, int spaceshipY, List<PictureBox> bulletsU)
        {
            foreach (PictureBox BulletU in bulletsU)
            {
                if ((BulletU.Location.X <= spaceshipX + 80) && (BulletU.Location.X >= spaceshipX - 15))
                {
                    if ((BulletU.Location.Y < spaceshipY + 75) && (BulletU.Location.Y > spaceshipY - 10))
                    {
                        BulletU.Location = new Point(BulletU.Location.X, BulletU.Location.Y + 10000);
                        temScore -= 30;
                    }
                }
            }
        }
        //
        // save score
        //
        private void timer6_Tick(object sender, EventArgs e)
        {
            ScoreList.Add(score.Number1);
            ScoreList.Add(score.Number2);
            ScoreList.Add(score.Number3);
            ScoreList.Add(score.Number4);
            ScoreList.Add(score.Number5);
            ScoreList.Add(score.Number6);
            ScoreList.Add(score.Number7);
            ScoreList.Add(score.Number8);
            ScoreList.Add(score.Number9);
            ScoreList.Add(score.Number10);

            ScoreList.Add(temScore);

            ScoreList.Sort();

            score.Number1 = ScoreList[10];
            score.Number2 = ScoreList[9];
            score.Number3 = ScoreList[8];
            score.Number4 = ScoreList[7];
            score.Number5 = ScoreList[6];
            score.Number6 = ScoreList[5];
            score.Number7 = ScoreList[4];
            score.Number8 = ScoreList[3];
            score.Number9 = ScoreList[2];
            score.Number10 = ScoreList[1];

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("score.ser",FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, score);
            stream.Close();

            MessageBox.Show(temScore.ToString());

            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Timer timer,timer10;
        int movement = 0, movement2=0;
        PictureBox pictureBox;
        int x, y,tempx,tempy,tempx2,tempy2;
        int x2, y2,tempx3,tempy3,tempx4,tempy4;
        List<PictureBox> picList, picList2;
        Random rnd;
        int score1=0, score2=0,count10=0,playeramount;

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1(playeramount).Show();
            Hide();
        }

        private void selectPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            Hide();
        }

        int seccount = 0,labelcount;
        bool isLabel = false, isPictureBox =false;

        public Form1(int playeramount)
        {
            InitializeComponent();
            this.playeramount = playeramount;

            pictureBox2a.BackColor = Color.Black;
            pictureBox3a.BackColor = Color.Blue;

            timer = new Timer();
            timer.Interval = 45;
            timer.Tick += Timer_Tick;
            timer.Start();

            timer10 = new Timer();
            timer10.Interval = 333;
            timer10.Tick += Timer10_Tick;
            timer10.Start();


            rnd = new Random();

            pictureBox2a.Location = new Point(rnd.Next(1, 80) * 10, rnd.Next(5, 53) * 10);

            pictureBox1a.BackColor = Color.Red;

            label1.Text = "Blue 0 - 0 Red";

            if(playeramount == 1)
            {
                pictureBox1a.Visible = false;
            }
        }

        private void Timer10_Tick(object sender, EventArgs e)
        {
            if(isPictureBox && pictureBox2a.BackColor == Color.Gold)
            {
                seccount++;

                if (pictureBox2a.Visible == true)
                {
                    pictureBox2a.Visible = false;
                }
                else
                {
                    pictureBox2a.Visible = true;
                }

                if (seccount == 30)
                {
                    seccount = 0;

                    pictureBox2a.BackColor = Color.Black;

                    pictureBox2a.Location = new Point(rnd.Next(1, 81) * 10, rnd.Next(5, 54) * 10);
                    pictureBox2a.Visible = true;
                    isPictureBox = false;

                    count10 = 0;
                }
            }

            if(isLabel)
            {
                labelcount++;

                if (label1.Visible == true)
                {
                    label1.Visible = false;
                }
                else
                {
                    label1.Visible = true;
                }

                if (labelcount == 6)
                {
                    labelcount = 0;

                    label1.Visible = true;
                    label1.ForeColor = Color.Black;
                    isLabel = false;
                }
            }
        }

        int truemovement, truemovement2;

        private void Timer_Tick(object sender, EventArgs e)
        {
            x = pictureBox1a.Location.X;
            y = pictureBox1a.Location.Y;

            x2 = pictureBox3a.Location.X;
            y2 = pictureBox3a.Location.Y;

            picList = this.Controls.OfType<PictureBox>().Where(x => !x.Name.Contains("a") && x.Tag.ToString() == "A").ToList();
            picList2 = this.Controls.OfType<PictureBox>().Where(x => !x.Name.Contains("a") && x.Tag.ToString() == "B").ToList();

            if (movement == 1)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X, pictureBox1a.Location.Y + 10);
                truemovement = movement;
            }
            else if(movement == 2)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X, pictureBox1a.Location.Y - 10);
                truemovement = movement;
            }
            else if (movement == 3)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X - 10, pictureBox1a.Location.Y);
                truemovement = movement;
            }
            else if (movement == 4)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X + 10, pictureBox1a.Location.Y);
                truemovement = movement;
            }

            if (movement2 == 1)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X, pictureBox3a.Location.Y + 10);
                truemovement2 = movement2;
            }
            else if (movement2 == 2)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X, pictureBox3a.Location.Y - 10);
                truemovement2 = movement2;
            }
            else if (movement2 == 3)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X - 10, pictureBox3a.Location.Y);
                truemovement2 = movement2;
            }
            else if (movement2 == 4)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X + 10, pictureBox3a.Location.Y);
                truemovement2 = movement2;
            }

            for (int i = 0; i < picList.Count; i++)
            {
                if (i == 0)
                {
                    tempx = picList[i].Location.X;
                    tempy = picList[i].Location.Y;

                    picList[i].Location = new Point(x, y);
                }
                else
                {
                    tempx2 = picList[i].Location.X;
                    tempy2 = picList[i].Location.Y;

                    picList[i].Location = new Point(tempx, tempy);

                    tempx = tempx2;
                    tempy = tempy2;
                }
            }

            for (int i = 0; i < picList2.Count; i++)
            {
                if (i == 0)
                {
                    tempx3 = picList2[i].Location.X;
                    tempy3 = picList2[i].Location.Y;

                    picList2[i].Location = new Point(x2, y2);
                }
                else
                {
                    tempx4 = picList2[i].Location.X;
                    tempy4 = picList2[i].Location.Y;

                    picList2[i].Location = new Point(tempx3, tempy3);

                    tempx3 = tempx4;
                    tempy3 = tempy4;
                }
            }

            

            isWall2();

            isWall();

            isBite();

            isBite2();

            isBig();
        }

        public void isBig()
        {
            if (pictureBox1a.Location == pictureBox2a.Location)
            {
                pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.BackColor = Color.Red;
                pictureBox.Tag = "A";
                pictureBox.Size = pictureBox1a.Size;
                this.Controls.Add(pictureBox);

                if (pictureBox2a.BackColor == Color.Gold)
                {
                    score2 += 5;
                    count10 = 0;
                    seccount = 0;
                }
                else
                {
                    score2++;
                }

                isLabel = true;
                labelcount = 0;
                label1.ForeColor = Color.Red;


                if ((score1 + score2 + count10) % 10 == 0)
                {
                    count10++;
                    pictureBox2a.BackColor = Color.Gold;

                    isPictureBox = true;
                }
                else
                {
                    pictureBox2a.BackColor = Color.Black;
                    pictureBox2a.Visible = true;
                }


                pictureBox2a.Location = new Point(rnd.Next(1, 81) * 10, rnd.Next(5, 54) * 10);

                label1.Text = "Blue " + score1 + " - " + score2 + " Red";
            }

            if (pictureBox3a.Location == pictureBox2a.Location)
            {
                pictureBox = new PictureBox();
                pictureBox.Location = new Point(x2, y2);
                pictureBox.BackColor = Color.Blue;
                pictureBox.Tag = "B";
                pictureBox.Size = pictureBox1a.Size;
                this.Controls.Add(pictureBox);

                if(pictureBox2a.BackColor == Color.Gold)
                {
                    score1 += 5;
                    count10 = 0;
                    seccount = 0;

                }
                else
                {
                    score1 ++;
                }

                isLabel = true;
                labelcount = 0;
                label1.ForeColor = Color.Blue;

                if ((score1 + score2 + count10) % 10 == 0)
                {
                    count10++;
                    pictureBox2a.BackColor = Color.Gold;

                    isPictureBox = true;
                }
                else
                {
                    pictureBox2a.BackColor = Color.Black;
                    pictureBox2a.Visible = true;
                }


                pictureBox2a.Location = new Point(rnd.Next(1, 81) * 10, rnd.Next(5, 54) * 10);

                label1.Text = "Blue " + score1 + " - " + score2 + " Red";
            }
        }

        public void isWall()
        {
            if (pictureBox1a.Location.X <= 0 && truemovement == 3)
            {
                pictureBox1a.Location = new Point(810, pictureBox1a.Location.Y);
            }
            else if (pictureBox1a.Location.X >= 810 && truemovement == 4)
            {
                pictureBox1a.Location = new Point(0, pictureBox1a.Location.Y);
            }
            else if (pictureBox1a.Location.Y <= 40 && truemovement == 2)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X, 540);
            }
            else if (pictureBox1a.Location.Y >= 540 && truemovement == 1)
            {
                pictureBox1a.Location = new Point(pictureBox1a.Location.X, 40);
            }
        }

        public void isWall2()
        {
            if (pictureBox3a.Location.X <= 0 && truemovement2 == 3)
            {
                pictureBox3a.Location = new Point(810, pictureBox3a.Location.Y);
            }
            else if (pictureBox3a.Location.X >= 810 && truemovement2 == 4)
            {
                pictureBox3a.Location = new Point(0, pictureBox3a.Location.Y);
            }
            else if (pictureBox3a.Location.Y <= 40 && truemovement2 == 2)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X, 540);
            }
            else if (pictureBox3a.Location.Y >= 540 && truemovement2 == 1)
            {
                pictureBox3a.Location = new Point(pictureBox3a.Location.X, 40);
            }
        }

        public void isBite()
        {
            for (int i = 0; i < picList.Count; i++)
            {
                if(picList[i].Location == pictureBox1a.Location)
                {
                    timer.Stop();
                    MessageBox.Show("GGWP");
                }
            }
        }

        public void isBite2()
        {
            for (int i = 0; i < picList2.Count; i++)
            {
                if (picList2[i].Location == pictureBox3a.Location)
                {
                    timer.Stop();
                    MessageBox.Show("GGWP");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Up && truemovement != 1)
                {
                    movement = 2;
                }
                else if (e.KeyCode == Keys.Down && truemovement != 2)
                {
                    movement = 1;
                }
                else if (e.KeyCode == Keys.Left && truemovement != 4)
                {
                    movement = 3;
                }
                else if (e.KeyCode == Keys.Right && truemovement != 3)
                {
                    movement = 4;
                }



                if (e.KeyCode == Keys.W && truemovement2 != 1)
                {
                    movement2 = 2;
                }
                else if (e.KeyCode == Keys.S && truemovement2 != 2)
                {
                    movement2 = 1;
                }
                else if (e.KeyCode == Keys.A && truemovement2 != 4)
                {
                    movement2 = 3;
                }
                else if (e.KeyCode == Keys.D && truemovement2 != 3)
                {
                    movement2 = 4;
                }

        }

        private void Form1_KeyDown1(object sender, KeyEventArgs e)
        {
            
        }
    }
}

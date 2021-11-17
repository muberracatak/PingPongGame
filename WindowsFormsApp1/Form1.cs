using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{



public partial class Form1 : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
 
        public int point = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playground.Bottom - (playground.Bottom / 10);
        }


   
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int formWidth, formHeight;
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;
         

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 0;
                speed_left += 2;
                speed_top = -speed_top;

                point += 1;
                points.Text = point.ToString();


            }

            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Right >= label4.Left)
            {
                speed_left = -speed_left;

            }

            /* if (ball.Left >= label2.Right || ball.Right <= label3.Left)
             {
                 this.ball.Location = new System.Drawing.Point(sayi.Next(30), sayi.Next(70));

             }*/
            Random sayi2 = new Random();
            //sayi2 = sayi2.Next(5);
            string[] renkler = { "blue", "red", "green", "black" ,"yellow"};
            if (ball.Bottom >= playground.Bottom)
            {             
                this.ball.Location = new System.Drawing.Point(sayi.Next(800), sayi.Next(10));
              
                    if (renkler[sayi2.Next(5)] == "blue")
                    {
                        this.ball.BackColor = Color.Blue;
                    }
                  
                    if (renkler[sayi2.Next(5)] == "red")
                    {
                        this.ball.BackColor = Color.Red;
                    }
                 

                    if (renkler[sayi2.Next(5)] == "green")
                    {
                        this.ball.BackColor = Color.Green;
                    }
                    

                    if (renkler[sayi2.Next(5)] == "black")
                    {
                        this.ball.BackColor = Color.Black;
                    }
                  

                    if (renkler[sayi2.Next(5)] == "yellow")
                    {
                        this.ball.BackColor = Color.Yellow;
                    }
                   




            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random sayi = new Random();
            if (timer2.Enabled == true)

            {
                this.ball.Location = new System.Drawing.Point(sayi.Next(800), sayi.Next(10));
                timer2.Enabled = false;

            }

            else

            {

                timer2.Enabled = true;

            }
        }
    }
}
/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
public partial class Form1 : Form
{
Mover.Moverd mover;
List movers = new List();
public Form1()
{
InitializeComponent();
}


private void randomBall(object sender, EventArgs e)
{
this.WindowState = FormWindowState.Maximized;
this.DoubleBuffered = true;
Timer timer = new Timer();
timer.Enabled = true;
timer.Interval = 10;
timer.Tick += timerTick;
this.Paint += randomBallPaint;

for (int i=0;i<5;i++)
{
mover = new Mover.Moverd(this.Width, this.Height);
movers.Add(mover);
}
}

private void randomBallPaint(object sender, PaintEventArgs e)
{
foreach (var item in movers)
{
item.Update();
item.Display(e.Graphics);
}
}

private void timerTick(object sender, EventArgs e)
{
Invalidate();
}
}
}
*/
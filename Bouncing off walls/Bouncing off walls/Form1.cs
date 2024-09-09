using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_off_walls
{
    public partial class Form1 : Form
    {
        private int ballSize = 20;
        private int posX = 50;
        private int posY = 50;
        private int dirX = 8;
        private int dirY = 8;     
        private Timer timer;
        
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 50; 
            timer.Tick += ticko;
            timer.Start();
        }
        private void ticko(object sender, EventArgs e)
        {
           
            if (posX + dirX >= 200 - ballSize || posX + dirX < 40)
            {
                dirX = -dirX;
            }
            if (posY + dirY >= 200- ballSize || posY + dirY < 20)
            {
                dirY = -dirY;
            }
            posX += dirX;
            posY += dirY;
            Invalidate();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics s = CreateGraphics();
            //Pen pens = new Pen(Color.Black, 3);
            //s.Graphics.DrawRectangle(pens, 40, 20, 160, 180);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, posX, posY, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Yellow, 100, posY, ballSize, ballSize);
            e.Graphics.FillEllipse(Brushes.Green, posX, 100, ballSize, ballSize);
            // Graphics s = CreateGraphics();
            Pen pens = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(pens,40, 20, 160, 180);
        }
    }
}

//for button must without Invalidate();  
//Graphics s = CreateGraphics();
//Pen pens = new Pen(Color.Black, 3);
//s.Graphics.DrawRectangle(pens, 40, 20, 160, 180);
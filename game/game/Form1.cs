using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
 
    public partial class Form1 : Form
    {
        SoundPlayer snd = new SoundPlayer(Properties.Resources.ushi);
       
        public Form1()
        {
          
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            pic1.Image = Properties.Resources.planet;
            pic2.Image = Properties.Resources.tank;
            pic3.Image = Properties.Resources.rocket;
        }
        int p = 55;
        int y = 259;
        int s = 325;
        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Left)
            {
               y -= 9;
                pic2.Location = new Point(y--, 353);
                pic3.Location = new Point(y--, 325);

            }
            if (e.KeyCode == Keys.Right)
            {
                y += 9;
                pic2.Location = new Point(y++, 353);
                pic3.Location = new Point(y++, 325);
            }
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false;
                PictureBox pic3 = new PictureBox();
                pic3.Name = "pic3";
                pic3.Size = new Size(22, 35);
                pic3.Location = new Point(299, 305);
                pic3.Image = Properties.Resources.rocket;
                pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pic3);
               
            }

            if (e.KeyCode == Keys.A)
            {
               
                timer1.Enabled = true;
            }
        }
        

        private async void timer1_Tick_1(object sender, EventArgs e)
        {

           
            s -= 10;
            pic3.Location = new Point(pic3.Location.X, s);
            if (pic3.Location.Y == 125 && pic3.Location.X > 260 && pic3.Location.X < 350)
            {
                snd.Play();


                pic1.Image = Properties.Resources.boom;
                this.Controls.Remove(pic3);
                pic3.Dispose();

                await Task.Delay(2700);


                this.Controls.Remove(pic1);

                pic1.Dispose();
               

            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}

}

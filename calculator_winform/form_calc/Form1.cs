using System;

namespace form_calc
{
    public partial class Form1 : Form
    {
        private double x = 0, y = 0, result = 0, num;
        private char a;
        // bool isNum = double.TryParse(str, out num);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isNum = double.TryParse(textBox1.Text, out num);


            if (isNum)
            {
                y = Convert.ToDouble(textBox1.Text);
                switch (a)
                {
                    case '+':
                        result = x + y;
                        break;
                    case '-':
                        result = x - y;
                        break;
                    case '*':
                        result = x * y;
                        break;
                    case '/':
                        result = x / y;
                        break;
                    default:
                        MessageBox.Show("Error ! \n invalid");
                        break;
                }
                MessageBox.Show("Cavab " + result);
                textBox1.PlaceholderText = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Error ! \n Кeqem daxil edin");
            }
            textBox1.Clear();
            y = 0;
            x = 0;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(textBox1.Text, out num);


            if (isNum) { x = Convert.ToDouble(textBox1.Text); a = '+'; textBox1.PlaceholderText = Convert.ToString(x); }
            else
            {
                MessageBox.Show("Error ! \n Кeqem daxil edin");
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(textBox1.Text, out num);


            if (isNum) { x = Convert.ToDouble(textBox1.Text); a = '-'; textBox1.PlaceholderText = Convert.ToString(x); }
            else
            {
                MessageBox.Show("Error ! \n Кeqem daxil edin");
            }
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(textBox1.Text, out num);


            if (isNum) { x = Convert.ToDouble(textBox1.Text); a = '/'; textBox1.PlaceholderText = Convert.ToString(x); }
            else
            {
                MessageBox.Show("Error ! \n Кeqem daxil edin");
            }
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isNum = double.TryParse(textBox1.Text, out num);


            if (isNum) { x = Convert.ToDouble(textBox1.Text); a = '*'; textBox1.PlaceholderText = Convert.ToString(x); }
            else
            {
                MessageBox.Show("Error ! \n Кeqem daxil edin");
            }

            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static listbox_form.@class;

namespace listbox_form
{

    public partial class Form1 : Form
    {
        public void AddItemToList(string item)
        {
            listBox1.Items.Add(item);
        }
        //public List<listadd> dataList = new List<listadd>();
        //listadd obj = new listadd();

        public List<listadd> list = new List<listadd>();

        public Form1()
        {
            InitializeComponent();
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            //list.Add(new listadd { id = 1, name = "wws", description = "wsqw" });
            //list.Add(new listadd { id = 2, name = "Yuliy", description = "777" });
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            int index = listBox1.SelectedIndex;
            foreach(listadd item in list)
            {
                if (index==item.id)
                {
                    MessageBox.Show($"id: {item.id}  {item.description}");
                }
            }
           
           
        }
    }        
}

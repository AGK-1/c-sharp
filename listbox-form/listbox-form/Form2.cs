using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static listbox_form.@class;

namespace listbox_form
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           listadd instance = new listadd();

            int result = instance.cnt();

           _form1.list.Add(new listadd {id=result, name = textBox1.Text, description = textBox2.Text });
           _form1.AddItemToList(textBox1.Text);

        }
    }
}

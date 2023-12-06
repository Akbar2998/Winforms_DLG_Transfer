using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLG
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }
        public string overall
        {
            get { return label5.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToString();
            string surname = textBox2.Text.ToString();
            string faculty = textBox3.Text.ToString();
            string degree = textBox4.Text.ToString();
            label5.Text = name + " " + surname + " \tstudies in the faculty " + faculty + " \tand  degree: " + degree;
            label5.Visible = false;
            Close();

        }
    }
}

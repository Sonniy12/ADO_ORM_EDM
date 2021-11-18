using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Size = new Size(700, 400);
            this.BackColor = Color.DarkSlateGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

       


        private void button4_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

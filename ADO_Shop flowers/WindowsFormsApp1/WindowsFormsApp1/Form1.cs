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
    { // Random ran = new Random();
        Flowers flowers;
        int n = 0;
        int n2 = 0;
        public Form1()
        {
            InitializeComponent();
            flowers = new Flowers();

        }


     


      

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowers = new Flowers();
            label1.Text = "" + flowers.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            flowers.Delet_fl();
            label1.Text = "" + flowers.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            flowers.Color_new();
            label1.Text = "" + flowers.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
            flowers.Clear();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            n = (int)numericUpDown1.Value;
            n2 = (int)numericUpDown2.Value;
            label1.Text +=" поз-я  "+n+" кол-во  "+n2 +"\n";

            flowers.Buy(n, n2, label1);
            //  label1.Text = "" + flowers.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

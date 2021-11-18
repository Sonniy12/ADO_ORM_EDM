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
    public partial class Form2 : Form
    {
        string res1 = "";
        public Form2()
        {
            InitializeComponent();
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Size = new Size(600, 300);
            this.BackColor = Color.DarkSlateGray;
            comboBox1.Items.Add("Защитник");
            comboBox1.Items.Add("Танк");
            comboBox1.Items.Add("Агрессор");
          
            comboBox1.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                res1 = comboBox1.SelectedItem.ToString();
                MessageBox.Show(res1);
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (res1 == "") return;

            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {
                var obj = (from x in connect.Hero
                           where x.name == res1
                           select x).FirstOrDefault();

                if (obj != null) { MessageBox.Show("Hero non!"); return; }

                Hero hero = new Hero();
                hero.name = res1;
                connect.Hero.Add(hero);
                connect.SaveChanges();
            }

            this.Close();
        }

     
    }
}

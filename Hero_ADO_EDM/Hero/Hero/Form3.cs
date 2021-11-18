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
    public partial class Form3 : Form
    {
        List<Hero> heroes;
        string res1 = "";
     
        public Form3()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Size = new Size(600, 300);
            this.BackColor = Color.DarkSlateGray;

            comboBox1.Items.Add("Эльфы");
            comboBox1.Items.Add("Люди");
            comboBox1.Items.Add("Гномы");
            comboBox1.Items.Add("Орки");
            comboBox1.Sorted = true;
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {
                heroes = (from x in connect.Hero select x).ToList();

                foreach (var x in heroes)
                {
                    listBox1.Items.Add(x.name);
                }

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            res1 = comboBox1.SelectedItem.ToString();
            MessageBox.Show(res1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "") return;
            if (listBox1.SelectedIndex == -1) { MessageBox.Show("Выбери тип героя."); return; }
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {
                Characteristics_hero character = new Characteristics_hero();
                character.name_hero = textBox1.Text;
                character.gender = textBox2.Text;
                character.age = int.Parse(textBox3.Text);
                character.specialized = textBox4.Text;
                character.race = res1;
                character.fk_hero = heroes[listBox1.SelectedIndex].id;
                connect.Characteristics_hero.Add(character);
                connect.SaveChanges();
            }
            this.Close();


        }

    
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Size= new Size( 1354 ,835);
            this.BackColor = Color.DarkSlateGray;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {

                var array = from x in connect.Hero
                           // where x.race=="Эльфы"
                             select x;
                foreach (var item2 in array)
                {
                    string result = "";
                   
                    foreach (var item in item2.Characteristics_hero)
                    {
                        result += item2.name;
                        if (item.race=="Эльфы")
                        {
                            result += " -- Возраст = " + item.age + "  полное имя = " + item.name_hero + "  раса = " + item.race + "  пол = " + item.gender + "  умения = " + item.specialized;
                            listBox1.Items.Add(result);
                            result = " ";
                        }
                       

                    }
                }    


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {

                var array = from x in connect.Hero
                                // where x.race=="Эльфы"
                            select x;
                foreach (var item2 in array)
                {
                    string result = "";

                    foreach (var item in item2.Characteristics_hero)
                    {
                        result += item2.name;
                        if (item.race == "Люди")
                        {
                            result += " -- Возраст = " + item.age + "  полное имя = " + item.name_hero + "  раса = " + item.race + "  пол = " + item.gender + "  умения = " + item.specialized;
                            listBox1.Items.Add(result);
                            result = " ";
                        }


                    }
                }


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {

                var array = from x in connect.Hero
                                // where x.race=="Эльфы"
                            select x;
                foreach (var item2 in array)
                {
                    string result = "";

                    foreach (var item in item2.Characteristics_hero)
                    {
                        result += item2.name;
                        if (item.race == "Орки")
                        {
                            result += " -- Возраст = " + item.age + "  полное имя = " + item.name_hero + "  раса = " + item.race + "  пол = " + item.gender + "  умения = " + item.specialized;
                            listBox1.Items.Add(result);
                            result = " ";
                        }


                    }
                }


            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (Hero_of_the_gameEntities connect = new Hero_of_the_gameEntities())
            {

                var array = from x in connect.Hero
                                // where x.race=="Эльфы"
                            select x;
                foreach (var item2 in array)
                {
                    string result = "";

                    foreach (var item in item2.Characteristics_hero)
                    {
                        result += item2.name;
                        if (item.race == "Гномы")
                        {
                            result += " -- Возраст = " + item.age + "  полное имя = " + item.name_hero + "  раса = " + item.race + "  пол = " + item.gender + "  умения = " + item.specialized;
                            listBox1.Items.Add(result);
                            result = " ";
                        }


                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

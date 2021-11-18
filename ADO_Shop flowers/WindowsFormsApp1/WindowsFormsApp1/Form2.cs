using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        List<New_flowers> flo = new List<New_flowers>();
        Random rand = new Random();

        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i <= 30; i++)
            {
                flo.Add(new New_flowers()
                {
                    Type = (Type_fl)rand.Next(0, 7),
                    Color = (Color_fl)rand.Next(0, 5),
                    Popularity = rand.Next(0, 100),
                    Price = rand.Next(130, 1000),
                      Amount  = rand.Next(0, 100)
                });
            }
            foreach (var item in flo)
            {
                listBox1.Items.Add(item.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Red = from i in flo
                      where i.Color == Color_fl.Красные && i.Type == Type_fl.Розы
                      select i;
            foreach (var item in Red)
            {
                listBox1.Items.Add("\n****\n"+item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Max = flo.Select((z => z.Price)).Max();
            var value = flo.Where(x => x.Price == Max);
            foreach (var item in value)
            {
                listBox1.Items.Add("\n****\n" + item.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var value = from i in flo
                      where i.Amount %2 ==0
                      select i;
            foreach (var item in value)
            {
                listBox1.Items.Add("\n****\n" + item.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var value = from i in flo
                        where i.Amount % 2 != 0 && i.Color==Color_fl.Желтые
                        select i;
            foreach (var item in value)
            {
                listBox1.Items.Add("\n****\n" + item.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var value= flo.Where(x => x.Price>150 && x.Price<300  || x.Price > 500 && x.Price < 900) ;
            foreach (var item in value)
            {
                listBox1.Items.Add("\n****\n" + item.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var value = flo.OrderByDescending(x => x.Popularity);
            int count = -1;
            
            foreach (var item in value)
            {
                count++;
                if (count<10)
                {
                    listBox1.Items.Add("\n****\n" + count + "#" + item.ToString());
                }
               
               
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var value = flo.OrderBy(x => x.Popularity);
            int count = -1;

            foreach (var item in value)
            {
                count++;
                if (count < 15)
                {
                    listBox1.Items.Add("\n****\n" + count + "#" + item.ToString());
                }
            }
        }

      
    }
}

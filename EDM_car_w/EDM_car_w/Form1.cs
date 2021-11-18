using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// добавила удаление услуги + обновление
/// </summary>

namespace EDM_car_w
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string number = maskedTextBox1.Text;
            if (number == "" || name == "")
            {
                return;
            }
           
           

            using (Connect db = new Connect())
            {
                var obj = (from x in db.Client_reserv
                           where x.phone == number
                           select x).FirstOrDefault();
                if (obj!=null)
                {
                    MessageBox.Show(" Клиент есть!!!");
                    return;
                }
                Client_reserv obj2 = new Client_reserv()
                { phone = number, name = name };

                db.Client_reserv.Add(obj2);
                    db.SaveChanges();
            }
            Form2 f2 = new Form2(number);
            f2.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(maskedTextBox1.Text);
            f3.ShowDialog();
          
        }
    }
}

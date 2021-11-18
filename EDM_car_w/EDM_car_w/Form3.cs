using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDM_car_w
{
    public partial class Form3 : Form
    {
        Client_add obj;
        List<services> list = new List<services>();
        List<basket> list2 = new List<basket>();
        int index = 0;

        public Form3( string phone)
        {
            InitializeComponent();
            obj = new Client_add(phone, label3);
            using (Connect db = new Connect())
            {
                var arr = from i in db.services
                          select i;
                //  int index = 0;
                foreach (var it in arr)
                {
                    list.Add(it);// записали список наименован
                    listBox1.Items.Add("Услуга №" + it.id + ": " + it.name_sevices + " цена = " + it.price);
                    //   index++;
                }

            }
            using (Connect db = new Connect())
            {
                var arr = (from i in db.Client_reserv
                         where obj. Number == i.phone
                         select i).FirstOrDefault();
                
                if (arr == null)
                {
                    return;
                }
                foreach (var item in arr.basket)
                {
                    list2.Add(item);// записали список наименован
                    listBox2.Items.Add("Услуга №  "+item.services.id + "  : " + item.services.name_sevices + "  price  " + item.services.price);
                   obj. total +=  item.services.price;
                }
              //  MessageBox.Show("" + obj.total);
               label3.Text = "" + obj.total;

            }

           
         // obj.Show_serves(listBox2);
        }
       
        int index1 = -1;
          int Index_element = 0;//занести значение индекса
        List<int> array = new List<int>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            for (int i = 0; i < array.Count; i++)
            {
                if (index == array[i])
                {
                    return;
                }
            }
            if (obj.Add(list[index].id, list[index].name_sevices, list[index].price))
            {
                array.Add(index);
            }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index1 = listBox2.SelectedIndex;
           // MessageBox.Show(""+index1);
                                           
          
      
        }

     async private void button1_Click(object sender, EventArgs e)
        {
            bool val = await obj.Reserve();
         
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex <0)
            {
                MessageBox.Show("Error!");
            }
            Index_element = list2[index1].id;//нахождения индекса услуги в корзине для удаления
                                             // MessageBox.Show(""+list2[index1].id);

            obj.Index = Index_element;
            MessageBox.Show("индекс услуги в корзине " + obj.Index);
            listBox2.Items.RemoveAt(index1);

            obj.Remove_serves2();
           
           

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update_form();
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            obj.Add_Date(dateTimePicker1.Value);
        }
        private void Update_form()
        {
            label3.Text = "";
            listBox2.Items.Clear();
            obj.total = 0;
            using (Connect db = new Connect())
            {
                var arr = (from i in db.Client_reserv
                           where obj.Number == i.phone
                           select i).FirstOrDefault();

                if (arr == null)
                {
                    return;
                }
                foreach (var item in arr.basket)
                {
                    list2.Add(item);// записали список наименован
                    listBox2.Items.Add("Услуга №" + item.services.id + ": " + item.services.name_sevices + "price" + item.services.price);
                    obj.total += item.services.price;
                }
                //  MessageBox.Show("" + obj.total);
                label3.Text = "" + obj.total;

            }
        }

     
    }
}

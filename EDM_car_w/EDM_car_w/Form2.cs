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
    public partial class Form2 : Form
    {
        Client_add obj;
        List<services> list = new List<services>();
        //string phone = "";
        public Form2( string phone)
        {
            InitializeComponent();
           // this.phone = phone;
            obj = new Client_add(phone, label3);
            using (Connect db = new Connect())
            {
                var arr=from i in db.services
                        select i;
              //  int index = 0;
                foreach( var it in arr)
                {
                    list.Add(it);// записали список наименован
                    listBox1.Items.Add("Услуга №" + it.id + ": " + it.name_sevices + " цена = " + it.price);
                     //   index++;
                }

            }

        } 

    

      async  private void button1_Click(object sender, EventArgs e)
        {
            //log
         bool val= await  obj.Reserve();
            if (val)
            {
                this.Close();
            }
           
          //  this.Close();


        }
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            obj.Add_Date(dateTimePicker1.Value);
        }


        List<int> array = new List<int>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            for (int i = 0; i < array.Count; i++)
            {
                if (index==array[i])
                {
                    return;
                }
            }
            if (obj.Add(list[index].id, list[index].name_sevices, list[index].price))
            {
                array.Add(index);
            }
          
        }




        //============================================================
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}

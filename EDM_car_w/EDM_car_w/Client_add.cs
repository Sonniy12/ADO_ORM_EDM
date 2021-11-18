using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EDM_car_w
{
    class Client_add
    {
        private Dictionary<int, string> Array;
        public decimal? total { get; set; }
        public string Number { get; private set; }
        public int Index { get;  set; }
        private DateTime date;
        private Label lab1;



        public Client_add(string name, Label lab)
        {
            Array = new Dictionary<int, string>();
            total = 0;
            Number = name;
            lab1 = lab;
            date = new DateTime(2000, 1, 1);
        }
        public bool Add(int id, string name, decimal? price)//проверка на добавление услуги
        {
            DialogResult dialog = MessageBox.Show(name, "добав услугу?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Array.Add(id, name);
                total += price;
                lab1.Text = "" + total;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Add_Date(DateTime date)//проверка даты на занято______ бронь
        {
            using (Connect db = new Connect())
            {
                var x = (from i in db.Date_reserv
                         where i.date == date
                         select i).FirstOrDefault();
                if (x != null)
                {
                    if (x.date.Month == date.Month && x.date.Day == date.Day && x.date.Hour == date.Hour)
                    {
                        MessageBox.Show("Error!");
                        return;
                    }
                }



            }
            this.date = date;

        }

        async public Task<bool> Reserve()//выполнение асинхронного режима
        {
            if (date < DateTime.Now)
            {
                MessageBox.Show("Выбрать дату?");
                return false;
            }
            if (Array.Count <= 0)
            {
                MessageBox.Show("Выбрать услугу?");
                return false;
            }

            using (Connect db = new Connect())
            {
                var objCl = (from i in db.Client_reserv
                             where i.phone == Number
                             select i).FirstOrDefault();
                if (objCl == null)
                {
                    MessageBox.Show("Error! not client!");
                    return false;
                }
                Date_reserv date_r = new Date_reserv();
                //  date_r.date = date;

                date_r.date = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0);

                date_r.fk_client = objCl.id;
                db.Date_reserv.Add(date_r);

                foreach (var item in Array.Keys)
                {
                    basket product = new basket();
                    product.fk_client_new = objCl.id;
                    product.fk_services = item;
                    db.basket.Add(product);
                }
                db.Database.Log += Log_save;//делегат  Database.Log подписанн на Log_save
                await db.SaveChangesAsync();//выполнение асинхронного режима

            }
            return true;
        }


        private void Log_save(string mes)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine("\n------------------------\n");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(mes);
                sw.WriteLine("\n------------------------\n");
            }

        }

        public void Show_serves(ListBox lb)
        {
            using (Connect db = new Connect())
            {

                var x = (from i in db.Client_reserv
                         where Number == i.phone
                         select i).FirstOrDefault();
                if (x == null)
                {
                    return;
                }
                foreach (var item in x.basket)
                {
                    Array.Add(item.services.id, item.services.name_sevices);
                    lb.Items.Add(item.services.name_sevices + "price" + item.services.price);
                    total += item.services.price;
                }
                lab1.Text = "" + total;

            }
        }
        //==================================
        
        public void Remove_serves2()
        {
            using (Connect db = new Connect())
            {

                var x = (from i in db.Client_reserv
                         where Number == i.phone
                         select i).FirstOrDefault();
                if (x == null)
                {
                    return;
                }
             
                basket element = db.basket.Find(Index);
                db.basket.Remove(element);
                db.SaveChanges();
                var obj = db.Entry(element);
                MessageBox.Show("" + obj.State);
            

            }
        }     


    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Flowers
    {
        private Random rand;
        int Step;
        private List<New_flowers> array_fl = new List<New_flowers>();
        //  int step=0;
        public Flowers()
        {
            rand = new Random();
           Step = -1;

            for (int i = 0; i <5; i++)
            {
               

                for (int j = 0; j <3; j++)
                {
                   

                    for (int x = 0; x < 3; x++)
                    {
                       
                        for (int c = 0; c < 3; c++)
                        {
                           
                        
                            for (int p = 0; p < 3; p++)
                            {

                                array_fl.Add(new New_flowers((Type_fl)rand.Next(0, 7), (Color_fl)rand.Next(0, 5), x = rand.Next(150, 950), c = rand.Next(0, 25),p=rand.Next(0,100)));

                            }

                        }
                    }
                }

            }

        }

        public string Show()
        {
            string res = "";

            int step = -1;

            for (int i = 0; i < array_fl.Count; i++)
            {
                step++;
               // Step++;
                res += " "+step+" " + array_fl[i].Name_fl +"\n";

            }
            return res;
        }

      

            public void Buy(int number, int val, Label l)
        {
            int res = 0;
            int res1 = 0;
            // int step =-1 ;
          //  l.Text = "";
            for (int i = 0; i < array_fl.Count; i++)
            {
                Step++;
                if (number==Step)
                {
                    try
                    {

                        l.Text += "#" + Step + " " + array_fl[i].Name + (array_fl[i].Amount - val) + "\n";
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }                             
                

            }  

        }

        public void Delet_fl()
        {


            array_fl.RemoveAt(0);

        }
        public void Color_new()
        {

            for (int i = 0; i < array_fl.Count; i++)
            {



                if (array_fl[i].Type == Type_fl.Пионы)
                {

                   
                    try
                    {
                        array_fl[i].Color = Color_fl.Красные;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
               



            }
            // Show();
        }

        public void Clear()
        {


            array_fl.Clear();


        }


    }
}

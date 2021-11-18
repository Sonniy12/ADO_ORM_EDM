using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class New_flowers
    {
        public Type_fl Type{get;set;}
        public Color_fl Color { get; set; }
        public int Popularity { get; set; }
        public double Price { get; set; }
        public int Amount { get => amount; set => amount = value; }
        private int prise;
        private int amount;
        private int popularity;

        public New_flowers(Type_fl t, Color_fl c,int p,int a,int popul_ty)
        {
            Type = t;
            Color = c;
            prise = p;
            Amount = a;
            Popularity = popul_ty;
        }
        public New_flowers() { }
     
        public string Name_fl
        {
            get => " -По популярности - " + Popularity +" - "  + Type + "  цвета " + Color + "  цена " + prise+"  шт."+Amount; 
        }
        public string Name
        {
            get => Type.ToString() + "  цвета " + Color.ToString() ;
        }

        public override string ToString()
        {
            return " -По популярности - " + Popularity + " - " + Type + "  цвета " + Color + "  цена " + Price + "  шт." + Amount;
        }
    }
}

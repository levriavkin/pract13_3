using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13_3
{
    class Kostume
    {
        string info = "";
        private string name;
        private int size;
        private string color;
        private string pol;
        private int price;
        private string Sizex;
        public Kostume(string name, int size, string color,string pol,int price,string Sizexx)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            this.pol = pol;
            this.price = price;
            this.Sizex = Sizexx;
        }

        public string getName()
        {
            return this.name;
        }
        public int getSize()
        {
            return this.size;
        }
        public string getColor()
        {
            return this.color;
        }
        public string getPol()
        {
            return this.pol;
        }
        public int getPrice()
        {
            return this.price;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSize(int size)
        {
            this.size = size;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void setPol(string pol)
        {
            this.pol= pol;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setSizex(string Sizexx)
        {
            this.Sizex = Sizexx;
        }
        public string getSizex()
        {
            return this.Sizex;
        }
        internal object Sizexx()
        {if (size > 40)
            {
                info = "Взрослый";
            }
            else info = "Ребенок";
            return info;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Good
    {
        private string name;
        private double price;

        public string Name { get { return name; }  }
        public double Price { get { return price; } }

        public Good(string name, double price)
        {
            this.name = name;   
            this.price = price;
        }

        public override string ToString()
        {
            return String.Format("{0},{1}", name, price);
        }
    }
}

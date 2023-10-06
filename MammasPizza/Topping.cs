using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammasPizza
{
    internal class Topping
    {
        public string Name { get;}
        public int Price { get; }
        public bool IsVeggie { get; }

        public Topping(string name, int price, bool isVeggie)
        {
            Name = name;
            Price = price;
            IsVeggie = isVeggie;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }


}

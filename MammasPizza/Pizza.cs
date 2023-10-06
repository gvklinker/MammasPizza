using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammasPizza
{
    internal class Pizza
    {
        //Instances
        private string _pizzaNo;
        private int _price;
        private List<Topping> _toppings = new List<Topping>();
        private string _name;

        //Constructor
        public Pizza(string pizNo, int price, List<Topping> tops, string name) {
            _pizzaNo = pizNo;
            _name = name;
            _price = price;
            _toppings.AddRange(tops);
        }
        //Properties
        public string PizzaNo {  get { return _name; } }
        public int Price { get { return _price; } }
        public List<Topping> Toppings { get {  return _toppings; } }
        public string Name { get { return _name; }}

        //Methods
        public void AddTopping(Topping top)
        {
            _toppings.Add(top);
        }
        public void RemoveTopping(Topping top) {  
            _toppings.Remove(top); 
        }
        public bool CheckIsVeggie() {
            for(int i = 0;  i < _toppings.Count; i++)
            {
                if (!_toppings[i].IsVeggie)
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{_pizzaNo} {_name} {_price}\n {string.Join(" ", _toppings)}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}

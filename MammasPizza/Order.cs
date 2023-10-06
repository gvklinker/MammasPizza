using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammasPizza
{
    internal class Order
    {
        private int _id;
        private double _cost;
        private DateTime _time;
        private List<Pizza> _pizzas = new List<Pizza>();
        private bool _delivery;
        private double _tax = 0;
        private static int _counter = 1;

        public Order() {
            _id = _counter++;
            _cost = 0;
            _time = DateTime.Now;
            _delivery = false;
        }
        public Order(List<Pizza> pizzas, bool delivery)
        {
            _id++;
            _pizzas.AddRange(pizzas);
            _delivery = delivery;
        }

        public int Id { get { return _id; } }
        public double Cost { get { return _cost; } }
        public DateTime Time { get { return _time; } }
        public List<Pizza> Pizzas { get { return _pizzas; } }
        public bool Delivery { get { return _delivery; } }

        public void PrintInfo()
        {
            Console.WriteLine($"\t #{_id}");
            foreach(var pizza in _pizzas)
            {
                pizza.PrintInfo();
            }
            if (_delivery)
                Console.WriteLine("Delivery");
            Console.WriteLine($"For at total cost of {CalculateTotalCost()} \n \t Served at: {_time}");

        }

        public void AddToOrder(Pizza piz) {
            _pizzas.Add(piz);
        }
        public void RemoveFromOrder(Pizza piz) {  
            _pizzas.Remove(piz);
        }

        public double CalculateTotalCost()
        {
            double cost = 0;
            foreach (var pizza in _pizzas)
                cost += pizza.Price;
            if (_delivery)
                cost += 40;
            cost += _tax;
            return cost;
        }
        public override string ToString()
        {
            return $"Order {_id} with {_pizzas.ToString()} ordered at {_time}, costing {CalculateTotalCost()}, is getting delivered: {_delivery}";
        }

    }
}

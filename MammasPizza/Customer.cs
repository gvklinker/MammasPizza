using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammasPizza
{
    internal class Customer
    {
        private string _name;
        private string _adress;
        private string _telephoneNo;
        private bool _inThaClub;
        private Order _order;

        public string Name { get { return _name; } set { _name = value; } }
        public string Adress { get { return _adress; } set { _adress = value; } }
        public string Telephone {  get { return _telephoneNo; } set { _telephoneNo = value; } }
        public bool InThaClub { get {  return _inThaClub; } }
        public Order Order { get { return _order; } }

        //public Customer() { }
        public Customer(string name, string adress, string telephoneNo)
        {
            _name = name;
            _adress = adress;
            _telephoneNo = telephoneNo;
            _inThaClub = false;
            _order = new Order();
        }

        public override string ToString()
        {
            return $"Name: {_name}, Adr: {_adress}, tlf: {_telephoneNo}, In Tha Club: {_inThaClub}";
        }
    }
}

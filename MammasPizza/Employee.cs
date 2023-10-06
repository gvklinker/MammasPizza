using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammasPizza
{
    internal class Employee
    {
        private string _name;
        private string _id;
        private string _mail;
        private bool _admin;

        public string Name { get { return _name; } }
        public string Id { get { return _id; } }
        public string Mail { get { return _mail; } }
        public bool Admin { get { return _admin; } }

        //public Employee() { }
        public Employee(string name, string id, string mail, bool admin)
        {
            _name = name;
            _id = id;
            _mail = mail;
            _admin = admin;
        }

        public override string ToString()
        {
            return $"Employee {_name} {_id} contact: {_mail}. Are they an admin: {_admin}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmethejob
{
    public class Contact
    {
        private string _name;
        private string _number;
        private string _address;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Adress
        {
            get { return _address; }
            set { _address = value; }
        }

        public Contact(string name, string number, string address)
        {
            this._name = name;
            this._number = number;
            this._address = address;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", this._name , this._number ,this._address);
        }


    }
}

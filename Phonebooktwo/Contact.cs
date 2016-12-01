using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmethejob
{
    public class Contact
    {
        private String name;
        private String number;
        private String adress;

        public Contact(String newName, String newNumber, String newAdress)
        {
            this.name = newName;
            this.number = newNumber;
            this.adress = newAdress;
        }

        public String _name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public String _number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public String _adress
        {
            get
            {
                return this.adress;
            }
            set
            {
                this.adress = value;
            }
        }

        public String toString()
        {
            return this.name + " " + this.number + " " + this.adress;
        }

        public static Contact loadFromFile(System.IO.TextReader textIn)
        {
            Contact result = null;

            try
            {
                string name = textIn.ReadLine();
                string number = textIn.ReadLine();
                string adress = textIn.ReadLine();

                result = new Contact(name, number, adress);
            }
            catch
            {
                return null;
            }
            return result;
        }


    }
}

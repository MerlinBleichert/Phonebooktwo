using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmethejob
{
    public class Phonebook
    {
        private int MAX_CONTACTS = 100;
        private int contactCounter = 0;
        private List<Contact> contacts;

        public Phonebook()
        {           
            this.contacts = new List<Contact>();
        }

        public void newContact(String name, String number, String adress)
        {
            Contact newOne = new Contact(name, number, adress);
            contacts.Add(newOne);
            contactCounter++;
        }

        public void addContact(Contact newOne)
        {
            contacts.Add(newOne);
            contactCounter++;
        }

        public void printAll()
        {
            for(int i = 0;i < contactCounter; i++)
            {
                Console.WriteLine(contacts[i].toString());
            }
        }

        public void readFromFile()
        {

        }

        public void saveToFile(System.IO.TextWriter textOut)
        {
            textOut.WriteLine(this.contactCounter);
            foreach (Contact tmpContact in this.contacts)
            {
                textOut.WriteLine(tmpContact._name);
                textOut.WriteLine(tmpContact._number);
                textOut.WriteLine(tmpContact._adress);
            }
        }
        public bool saveToFile(String filename)
        {
            System.IO.TextWriter textOut = null;
            try
            {
                textOut = new System.IO.StreamWriter(filename);
                saveToFile(textOut);
            }
            catch
            {
                return false;
            }
            finally
            {
                if(textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        public void sortByName()
        {
          
        }
    }
}

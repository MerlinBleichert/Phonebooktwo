using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmethejob
{
    public class Phonebook
    {
        private List<Contact> contacts = new List<Contact>();


        public Phonebook()
        {
        }

        public Phonebook(List<Contact> contacts) : base()
        {
            this.contacts = contacts;
        }

        public void AddContact(Contact contact)
        {
            if (!this.contacts.Contains(contact))
                contacts.Add(contact);
        }

        public void DeleteContact(String name)
        {
            int indexOfContact = SearchContactByName(name);

            if (indexOfContact != -1)
            {
                contacts.RemoveAt(indexOfContact);
            }
        }

        public List<Contact> GetContactCopy()
        {
            return new List<Contact>(contacts);
        }

        public int SearchContactByName(String name)
        {                    
            return contacts.FindIndex(x => x.Name.Equals(name));
        }

        public void SortByName()
        {
            this.contacts = this.contacts.OrderBy(c => c.Name).ToList();
        }
    }
}

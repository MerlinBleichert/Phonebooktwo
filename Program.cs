using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebooktwo;
using Phonebooktwo.DataStore;

namespace Gimmethejob
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataStore<List<Contact>> datastore = new CSVDataStore("contacts.csv");
            Phonebook phonebook = new Phonebook(datastore.LoadData());

            Console.WriteLine("Add contacts, enter quit in name to stop adding contacts");
            int menucommand = 0;
            while (menucommand != 4)
            {

                PrintMenu();
                menucommand = int.Parse(Console.ReadLine());
                switch( menucommand){
                    case 1 :
                        AddContact(phonebook);
                        break;
                    case 2:
                        DeleteContact(phonebook);
                        break;
                    case 3:
                        PrintAllContacts(phonebook.GetContactCopy());
                        break;
                    
                }

            }

            Console.ReadLine();


            datastore.SaveData(phonebook.GetContactCopy());
        }

        public static void PrintAllContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
                Console.WriteLine(contact);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add Contacts ");
            Console.WriteLine("2. Delete Contacts");
            Console.WriteLine("3. Print all contacts ");
            Console.WriteLine("4. Quit ");
        }

        public static void AddContact(Phonebook phonebook)
        {
            Console.WriteLine("Enter a name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            String number = Console.ReadLine();
            Console.WriteLine("Anter an adress: ");
            String adress = Console.ReadLine();

            phonebook.AddContact(new Contact(name, number, adress));
        }
        public static void DeleteContact(Phonebook phonebook)
        {
            Console.WriteLine("Enter the name of the contact you want to delete: ");
            phonebook.DeleteContact(Console.ReadLine());
        }

    }
}

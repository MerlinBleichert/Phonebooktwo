using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimmethejob
{
    class Program
    {
        static void Main(string[] args)
        {
            Phonebook contacts = new Phonebook();
            System.IO.TextReader textIn = new System.IO.StreamReader("phonebook.txt");
            loadFromFile(textIn, contacts);

            Console.WriteLine("Add contacts, enter quit in name to stop adding contacts");
            while (true)
            {
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                if (name.Equals("quit"))
                {
                    break;
                }
                Console.WriteLine("Number: ");
                String number = Console.ReadLine();
                Console.WriteLine("Adress: ");
                String adress = Console.ReadLine();

                contacts.newContact(name, number, adress);
            }

            

            contacts.printAll();
            Console.ReadLine();



            contacts.saveToFile("phonebook.txt");
            

        }

        public static Phonebook loadFromFile(System.IO.TextReader textIn,Phonebook contacts)
        {
            
            int numberOfContacts = int.Parse(textIn.ReadLine());

            for(int i = 0; i < numberOfContacts; i++)
            {
                contacts.addContact(Contact.loadFromFile(textIn));
            }

            if(textIn != null)
            {
                textIn.Close();
            }

            return contacts;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsEF_StartSqlLite1.Data;
using ConsEF_StartSqlLite1.Models;

namespace ConsEF_StartSqlLite1
{
    public class ContactPresenter {
        private ContactRepo repo;

        public ContactPresenter(ContactRepo repo) {
            this.repo = repo;
        }
        public  void ShowAll(List<Contact> contacts) {
            Console.WriteLine(" ------- LISTA KONTAKTÓW ----------");
            foreach (Contact c in contacts)
            {
                Console.WriteLine($"Id: {c.Id} --> {c.FirstName} {c.LastName} Adres: {c.Address}");
            }
            Console.WriteLine("----------------------------------------------");
        }

        public Contact GetFromConsole() {
            Contact contact = null;

            Console.Write("Podaj imie: ");
            string firstname = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string lastname = Console.ReadLine();
            Console.Write("Podaj adres: ");
            string address = Console.ReadLine();
            if (!String.IsNullOrEmpty(firstname) && !String.IsNullOrEmpty(lastname)
                                                 && !String.IsNullOrEmpty(address))
            {
                contact = new Contact { FirstName = firstname, LastName = lastname, Address = address };
            }

            return contact;
        }

        public string GetQuery() {
            Console.Write("Podaj fraze do wyszukania: ");
            return Console.ReadLine();
        }
    }
}

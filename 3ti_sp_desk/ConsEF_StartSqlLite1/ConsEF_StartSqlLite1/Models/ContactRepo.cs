using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsEF_StartSqlLite1.Data;

namespace ConsEF_StartSqlLite1.Models
{
    public class ContactRepo {
        private ContactDBContext _db;

        public ContactRepo() {
            _db = new ContactDBContext();
        }

        public List<Contact> GetAll() {
            return _db.Contacts.ToList();
        }

        public void AddNewContact(Contact contact) {
            _db.Contacts.Add(contact);
            _db.SaveChanges();
        }

        public bool RemoveContact(int id) {
            Contact toRemove = _db.Contacts.Find(id);
            if (toRemove != null) {
                _db.Contacts.Remove(toRemove);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Contact> GetSearch(string query) {
            return _db.Contacts.Where(
                c => (c.LastName.ToLower().Contains(query.ToLower()) 
                      || c.FirstName.ToLower().Contains(query.ToLower()))).ToList();
        }
    }
}

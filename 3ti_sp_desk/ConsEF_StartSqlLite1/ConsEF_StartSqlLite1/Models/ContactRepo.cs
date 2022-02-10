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
    }
}

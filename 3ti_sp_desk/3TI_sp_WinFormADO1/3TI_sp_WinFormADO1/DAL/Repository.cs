
using _3TI_sp_WinFormADO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TI_sp_WinFormADO1.DAL
{
    public class Repository
    {
        public List<Book> Books { get; set; }
        public string ConnString { get; set; }

        public Repository() {
            this.ConnString = Properties.Settings.Default.ConnString;
        }
    }
}

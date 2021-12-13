using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithListVew.Models
{
    public class Gift
    {
        public Gift() {
            _keyGuid = Guid.NewGuid();
        }

        private Guid _keyGuid;
        public Guid KeyGuid {
            get { return _keyGuid; }
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public string NamePrice {
            get {
                return $"{Name}: {Price} PLN";
            }
        }
    }
}

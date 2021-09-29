using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ti_classFirst
{
    public class User
    {
        //fields
        private string name = "Wasyl";

        private int age = 18;

        public int Age { //property
            get {
                return age<18 ? -1: age;
            }
            set {
                age = value<0 ? -value : value;
            }
        }

        public string Login { get; set; } = "Loginek";   //auto propery
        /*
         * private string _login;
         * public string Login{get{ return _login;} set{_login = value;}};
         */

        //methods
        public string GetName() {
            return name;
        }

        public void SetName(string value) {
            name = value;
        }

        public override string ToString() {
            return $"Name: {GetName()} Age: {Age} Login: {Login}";
        }

        public string IsAdult() {
            return age >= 18 ? "pelnoletni" : "niepoelnoletni";
        }
    }
}

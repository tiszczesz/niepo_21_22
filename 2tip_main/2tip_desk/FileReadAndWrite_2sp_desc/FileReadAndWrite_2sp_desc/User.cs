using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReadAndWrite_2sp_desc
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Uzytkownik {FirstName} {LastName}"+Environment.NewLine);
            sb.Append($"Login: {Login} wiek: {Age}");
            return sb.ToString();
        }

        public string ToLine() {
            return $"{Id};{Login};{FirstName};{LastName};{Age}";
        }

        public static User FromLine(string line) {
            string[] dane = line.Split(';'); //"qwqw;qwqw;34;dfd" -> ["qwqw",....]
            return new User {
                Id = Convert.ToInt32(dane[0]),
                Login = dane[1],
                FirstName = dane[2],
                LastName = dane[3],
                Age = Convert.ToInt32(dane[4])
            };
        }

        public string ToJSON() {
            return JsonSerializer.Serialize(this);
        }

        public static User FromJSON(string line) {
            User result = JsonSerializer.Deserialize<User>(line);
            return result;
        }
    }
}

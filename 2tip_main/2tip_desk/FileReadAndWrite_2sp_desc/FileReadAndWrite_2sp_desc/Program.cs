using System;
using System.Collections.Generic;

namespace FileReadAndWrite_2sp_desc
{
    class Program
    {
        static void Main(string[] args) {
            List<User> users = new List<User> {
                new User {Id = 1, Login = "roman", FirstName = "Roman", LastName = "Wałecki", Age = 33},
                new User {Id = 2, Login = "tomasz", FirstName = "Tomasz", LastName = "Turek", Age = 14},
                new User {Id = 3, Login = "rysio", FirstName = "Ryszard", LastName = "Hajduk", Age = 21},
                new User {Id = 4, Login = "monia", FirstName = "Monika", LastName = "Wałecka", Age = 29},
                new User {Id = 5, Login = "tymek", FirstName = "Tymoteusz", LastName = "Wałecki", Age = 33},
            };
            Repository repo = new Repository();
           // repo.ToFile(users);
           // repo.ToJSONFile(users,"data_json.txt");
           //var gg = repo.FromJSONFile("dane.txt");

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace FileReadAndWrite_2sp_desc
{
    class Program
    {
        static void Main(string[] args) {
            List<User> users = new List<User> {
                new User { Login = "roman", FirstName = "Roman", LastName = "Wałecki", Age = 33},
                new User { Login = "tomasz", FirstName = "Tomasz", LastName = "Turek", Age = 14},
                new User { Login = "rysio", FirstName = "Ryszard", LastName = "Hajduk", Age = 21},
                new User { Login = "monia", FirstName = "Monika", LastName = "Wałecka", Age = 29},
                new User { Login = "tymek", FirstName = "Tymoteusz", LastName = "Wałecki", Age = 33},
                new User { Login = "dymek", FirstName = "Dominik", LastName = "Rygowski", Age = 14},
            };
            Repository repo = new Repository();
           // repo.ToFile(users);
          if(!File.Exists("usersJSON.txt")) 
              repo.ToJSONFile(users,"usersJSON.txt");
           // var list = repo.FromFile();
            var list = repo.FromJSONFile("usersJSON.txt");
            foreach (User u in list) {
                Console.WriteLine(u);
            }
            Guid guid = Guid.NewGuid();
            // repo.ToJSONFile(users,"data_json.txt");
            //var gg = repo.FromJSONFile("dane.txt");
            //wyswietlanie w konsoli 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReadAndWrite_2sp_desc
{
    public class Repository {
        private string _fileName;
        public Repository(string fileName="dane.txt") {
            _fileName = fileName;
        }

        public void ToFile(List<User> users) {
            using (StreamWriter sw = new StreamWriter(_fileName)) {
                foreach (User u in users) {
                    sw.WriteLine(u.ToLine());
                }
            }
        }

        public void ToJSONFile(List<User> users,string fileName) {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (User u in users)
                {
                    sw.WriteLine(u.ToJSON());
                }
            }
        }

        public List<User> FromJSONFile(string filename) {
            List<User> list = new List<User>();
            using (StreamReader sr = new StreamReader(filename)) {
                string line = "";
                while ((line = sr.ReadLine()) != null) {
                    list.Add(User.FromJSON(line));
                }
            }

            return list;
        }
    }
}


using _3TI_sp_WinFormADO1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Books = GetAllBooks();
        }

        public List<Book> GetAllBooks() {
            List<Book> books = new List<Book>();
            using (SqlConnection conn = new SqlConnection(ConnString)) {
                string sqlQuery = "SELECT Id,Title,Author,Price,Description,Image FROM dbo.Books";
                using (SqlCommand command = new SqlCommand(sqlQuery,conn)) {
                    conn.Open();
                    SqlDataReader sr = command.ExecuteReader();
                    if (sr.HasRows) {
                        while (sr.Read()) {
                            books.Add(getFromRecord(sr));
                        }
                    }
                }
            }
            return books;
        }
        private Book getFromRecord(SqlDataReader sr) {
            return new Book {
                Id = sr.GetInt32(0),
                Title = sr.GetString(1),
                Author = sr.GetString(2),
                Price = sr.GetDecimal(3),
                Description = sr.IsDBNull(4)? "":sr.GetString(4) ,
                Image = sr.IsDBNull(5)?"" : sr.GetString(5)
            };
        }
    }
}

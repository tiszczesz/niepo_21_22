
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
                }
            }

            return books;
        }
    }
}

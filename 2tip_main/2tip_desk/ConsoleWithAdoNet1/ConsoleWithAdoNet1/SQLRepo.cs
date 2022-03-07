using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWithAdoNet1
{
    public class SQLRepo {
        private readonly string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Workers_2tp_1;Integrated Security=True";

        public SqlConnection GetConnection() {
            return new SqlConnection(connection);
        }

        public List<Worker> GetWorkers() {
            List<Worker> workers = new List<Worker>();
            using (SqlConnection conn = new SqlConnection(connection)) {
                string query = "SELECT * FROM Workers order by LastName";
                SqlCommand command = new SqlCommand(query, conn);
                try {
                    //todo
                    conn.Open();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
            return workers;
        }
    }
}

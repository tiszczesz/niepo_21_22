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
                string query = "SELECT Id,FirstName,LastName,Position FROM Workers order by LastName";
                SqlCommand command = new SqlCommand(query, conn);
                try {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        var worker = new Worker {
                            Id = reader.GetInt32(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            Position = reader.IsDBNull(3) ? "" : reader.GetString(3)
                        };
                        workers.Add(worker);
                    }
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

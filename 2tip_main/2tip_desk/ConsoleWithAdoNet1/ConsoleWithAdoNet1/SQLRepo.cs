using System;
using System.Collections.Generic;
using System.Data;
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

        public void AddWorker(Worker worker) {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "INSERT INTO Workers(FirstName,LastName,Position) VALUES(@FirstName,@LastName,@Position)";

                SqlCommand command = new SqlCommand(query, conn);
                try {
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = worker.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = worker.LastName;
                    command.Parameters.Add("@Position", SqlDbType.NVarChar, 50).Value = worker.Position;
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw1_gim_ADO_1.Models;
using System.Data.SqlClient;

namespace cw1_gim_ADO_1.DAL
{
    public class Repository
    {
        public List<Animal> Animals { get; set; }
        public List<Species> SpeciesList { get; set; }
        private string connString;

        public Repository() {
            this.connString =  Properties.Settings.Default.connString;
            Animals = getAllAnimals();
        }

        public List<Animal> getAllAnimals() {
            List<Animal> animals = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(connString)) {
                string sqlText = "SELECT Animals.Id,Animals.Name,Animals.Description,SpeciesId,Image, Species.Name FROM Animals "
                                 +" INNER JOIN Species ON SpeciesId=Species.Id";
                using (SqlCommand sqlCommand = new SqlCommand(sqlText,connection)) {
                    connection.Open();
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    if (sr.HasRows) {
                        while (sr.Read()) {
                            animals.Add(getFromReader(sr));
                        }
                    }
                }
                connection.Close();
            }
            return animals;
        }

        private Animal getFromReader(SqlDataReader sr) {

            Animal animal = new Animal {
                Id = sr.GetInt32(0),
                Name = sr.GetString(1),
                Description = sr.GetString(2),
                Species = sr.GetInt32(3),
                Image = sr.GetString(4)
            };
            return animal;
        }

    }
}

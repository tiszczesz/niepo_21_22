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
        
        private string connString;

        public Repository() {
            this.connString =  Properties.Settings.Default.connString;
            Animals = getAllAnimalsSpecies();
        }

        public List<Animal> getAllAnimalsSpecies() {
            List<Animal> animals = new List<Animal>();
            using (SqlConnection connection = new SqlConnection(connString)) {
                string sqlText = "SELECT Animals.Id,Animals.Name,Animals.Description,SpeciesId,Image, Species.Name,Species.Description FROM Animals "
                                 + " INNER JOIN Species ON SpeciesId=Species.Id";
                using (SqlCommand sqlCommand = new SqlCommand(sqlText,connection)) {
                    connection.Open();
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    if (sr.HasRows) {
                        while (sr.Read()) {
                            animals.Add(getFromReaderAnimal(sr));
                        }
                    }
                }
                connection.Close();
            }
            return animals;
        }

        public void InsertAnimal(Animal animal)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string sqlText = "INSERT INTO  Animals(Name,Description,SpeciesId) VALUES(@name,@description,@speciesId)";
                using (SqlCommand sqlCommand = new SqlCommand(sqlText, connection)) {
                    sqlCommand.Parameters.AddWithValue("name", animal.Name);
                    sqlCommand.Parameters.AddWithValue("description", animal.Description);
                    sqlCommand.Parameters.AddWithValue("speciesId", animal.SpeciesId);
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Species> getAllSpecies()
        {
            List<Species> species = new List<Species>();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string sqlText = "SELECT Species.Id, Species.Name,Species.Description FROM Species Order by Species.Name";
                using (SqlCommand sqlCommand = new SqlCommand(sqlText, connection))
                {
                    connection.Open();
                    SqlDataReader sr = sqlCommand.ExecuteReader();
                    if (sr.HasRows)
                    {
                        while (sr.Read())
                        {
                            species.Add(getFromReaderOnlySpecies(sr));
                        }
                    }
                }
                connection.Close();
            }
            return species;
        }
        private Animal getFromReaderAnimal(SqlDataReader sr) {

            Animal animal = new Animal {
                Id = sr.GetInt32(0),
                Name = sr.GetString(1),
                Description = sr.IsDBNull(2)?"": sr.GetString(2),
                SpeciesId = sr.GetInt32(3),
                Image = sr.IsDBNull(4)?"": sr.GetString(4),
                Species = getFromReaderSpecies(sr)
            };
            return animal;
        }

        private Species getFromReaderSpecies(SqlDataReader sr) {
            Species species = new Species {
                Id = sr.GetInt32(3),
                Name = sr.GetString(5),
                Description = sr.IsDBNull(6)?"":sr.GetString(6)
            };
            return species;
        }
        private Species getFromReaderOnlySpecies(SqlDataReader sr)
        {
            Species species = new Species
            {
                Id = sr.GetInt32(0),
                Name = sr.GetString(1),
                Description = sr.IsDBNull(2) ? "" : sr.GetString(2)
            };
            return species;
        }

    }
}

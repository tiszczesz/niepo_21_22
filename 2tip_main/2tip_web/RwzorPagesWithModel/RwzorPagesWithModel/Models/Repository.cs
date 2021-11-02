using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RwzorPagesWithModel.Models
{
    public class Repository
    {
        public static List<Film> GetFilms() {
            return new List<Film> {
                new Film {
                    Id = 1, Title = "Alicja w krainie czarów", Author = "Roman Polański",
                    Price = 39.99M, DateOfRelease = new DateTime(2015, 7, 12)
                },
                new Film {
                    Id = 2, Title = "Mroki nocy", Author = "Maryna Górska",
                    Price = 39.99M, DateOfRelease = new DateTime(2017, 12, 12)
                },
                new Film {
                    Id = 3, Title = "Nowe czasy", Author = "Tomasz Bomasz",
                    Price = 39.99M, DateOfRelease = new DateTime(1999, 4, 3)
                },
                new Film {
                    Id = 4, Title = "Wojna 20-letnia", Author = "Artur Bartur",
                    Price = 39.99M, DateOfRelease = new DateTime(2020, 8, 11)
                },
                new Film {
                    Id = 5, Title = "Ostatni film", Author = "Monika Relikt",
                    Price = 39.99M, DateOfRelease = new DateTime(2009, 6, 23)
                },
            };
        }
    }
}

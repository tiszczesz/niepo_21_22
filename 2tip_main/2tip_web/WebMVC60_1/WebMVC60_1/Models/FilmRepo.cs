namespace WebMVC60_1.Models
{
    public class FilmRepo
    {
        public static List<Film> GeFilms() {
            return new List<Film> {
                new Film { Id = 1,Title = "tytuł 1",Date = new DateTime(2010, 12, 16) },
                new Film { Id = 2,Title = "tytuł 23", Date = new DateTime(2009, 2, 20) },
                new Film { Id = 3,Title = "tytuł 34", Date = new DateTime(1989, 8, 12) },
            };
        }
    }
}

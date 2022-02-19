namespace WebApii60_sp.Models
{
    public class FakeFilmRepo : IFilmRepo {
        private List<Film> _films = new List<Film> {
            new Film{Id = 1,Title = "Szeregowiec Ryan",Director = "Tomasz Bomasz",
                CreateDate = new DateTime(2010,5,12)},
            new Film{Id = 2,Title = "Gwiezdne wojny 1",Director = "Helena Melena",
                CreateDate = new DateTime(2010,5,12)},
            new Film{Id = 3,Title = "Gwiezdne wojny 2",Director = "Tomasz Małecki",
                CreateDate = new DateTime(2010,4,23)},
            new Film{Id = 4,Title = "Gwinea",Director = "Anna Wanna",
                CreateDate = new DateTime(2008,5,12)},
            new Film{Id = 5,Title = "Wojna i Pokój",Director = "Roman Polański",
                CreateDate = new DateTime(1990,8,21)},
        };
        public IEnumerable<Film> GetFilms() {
            return _films;
        }

        public Film GetFilmById(int id) {
            return _films.Find(f => f.Id == id);
        }

        public IEnumerable<Film> DeleteFilm(int id) {
           Film filmToDelete = _films.Find(f => f.Id == id);
           if (filmToDelete != null) {
               _films.Remove(filmToDelete);
           }
           return _films;
        }

        public IEnumerable<Film> UpdateFilm(int id, Film film) {
            Film filmToUpdate = _films.Find(f => f.Id == id);
            if (filmToUpdate != null) {
                filmToUpdate.Title = film.Title;
                filmToUpdate.Director = film.Director;
                filmToUpdate.CreateDate = film.CreateDate;
            }

            return _films;
        }

        public IEnumerable<Film> AddFilm(Film film) {
            _films.Add(film);
            return _films;
        }
    }
}

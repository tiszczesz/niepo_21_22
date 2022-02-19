using WebApii60_sp.Data;

namespace WebApii60_sp.Models
{
    public class SqLiteFilmRepo :IFilmRepo {
        private FilmDbContext _db;

        public SqLiteFilmRepo(FilmDbContext db) {
            _db = db;
        }
        public IEnumerable<Film> GetFilms() {
            return _db.Films.ToList();
        }

        public Film GetFilmById(int id) {
            return _db.Films.Find(id);
        }

        public IEnumerable<Film> DeleteFilm(int id) {
            var filmToDelete = _db.Films.Find(id);
            if (filmToDelete != null) {
                _db.Films.Remove(filmToDelete);
                _db.SaveChanges();
            }
            return _db.Films.ToList();
        }

        public IEnumerable<Film> UpdateFilm(int id, Film film) {
            var filmToUpdate = _db.Films.Find(id);
            if (filmToUpdate != null) {
                filmToUpdate.Title= film.Title?? filmToUpdate.Title;
                filmToUpdate.Director= film.Director?? filmToUpdate.Director;
                filmToUpdate.CreateDate= film.CreateDate;
                _db.SaveChanges();
            }

            return _db.Films.ToList();
        }

        public IEnumerable<Film> AddFilm(Film film) {
            if (film != null) {
                _db.Films.Add(film);
                _db.SaveChanges();
            }

            return _db.Films.ToList();
        }
    }
}

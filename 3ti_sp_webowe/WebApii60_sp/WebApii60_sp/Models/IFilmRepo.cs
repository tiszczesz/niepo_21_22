namespace WebApii60_sp.Models
{
    public interface IFilmRepo {
        IEnumerable<Film> GetFilms(); //GET
        Film GetFilmById(int id); //GET
        IEnumerable<Film> DeleteFilm(int id); //DELETE
        IEnumerable<Film> UpdateFilm(int id, Film film); //PUT

        IEnumerable<Film> AddFilm(Film film); //POST

    }
}

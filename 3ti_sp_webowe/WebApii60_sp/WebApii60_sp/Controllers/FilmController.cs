using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApii60_sp.Models;

namespace WebApii60_sp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase {
        private IFilmRepo _repo;

        public FilmController(IFilmRepo repo) {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Film>> Get() {
            var films = _repo.GetFilms();
            if (films == null) {
                return BadRequest();
            }

            return Ok(films);
        }

        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id) {
            Film film = _repo.GetFilmById(id);
            if (film == null) {
                return NotFound();
            }

            return Ok(film);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Film>> Post(Film film) {
            
            return Ok(_repo.AddFilm(film));
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Film>> Delete(int id) {
            return Ok(_repo.DeleteFilm(id));
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Film>> Put(int id, Film film) {
            return Ok(_repo.UpdateFilm(id, film));
        }
    }
}

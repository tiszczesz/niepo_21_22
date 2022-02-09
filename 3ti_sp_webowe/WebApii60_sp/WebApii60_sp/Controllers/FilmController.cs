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
    }
}

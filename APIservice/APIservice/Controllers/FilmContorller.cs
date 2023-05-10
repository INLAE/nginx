using Microsoft.AspNetCore.Mvc;
using WepAppLinux.Models;

namespace WepAppLinux.Controllers
{
    [Route("api/films")]
    [ApiController]
    public class FilmContoller : ControllerBase
    {
        private List<Film> Films { get; set; }

        public FilmContoller()
        {
            Films = new List<Film>()
            {
                new Film() { Id = 1, Title = "Guardians of the Galaxy Volume 3", Director = "James Gunn" },
                new Film() { Id = 2, Title = "The Whale", Director = "Darren Aronofsky" },
                new Film() { Id = 3, Title = "Babylon", Director = "Damien Chazelle" },
            };
        }

        [HttpGet]
        public ActionResult GetAllFilms()
        {
            return Ok(Films);
        }
    }
}
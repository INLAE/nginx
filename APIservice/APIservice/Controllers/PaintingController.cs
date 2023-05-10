using Microsoft.AspNetCore.Mvc;
using WepAppLinux.Models;

namespace WepAppLinux.Controllers
{
    [Route("api/shoes")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private List<Shoes> Shoes { get; set; }

        public ShoesController()
        {
            Shoes = new List<Shoes>()
            {
                new Shoes() { Id = 1, Brand = "Nike", Name = "Space Hippie 04 Light Bone" },
                new Shoes() { Id = 2, Brand = "Lacoste", Name = "GRADUATE" },
                new Shoes() { Id = 3, Brand = "Adidas", Name = "Alphabounce 3" }
            };
        }

        [HttpGet]
        public ActionResult GetAllShoes()
        {
            return Ok(Shoes);
        }
    }
}
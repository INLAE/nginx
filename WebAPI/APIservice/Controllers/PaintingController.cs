using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WepAppLinux.Models;

namespace WepAppLinux.Controllers
{
    [Route("api/paintings")]
    [ApiController]
    public class PaintingController : ControllerBase
    {
        private List<Painting> Paintings { get; set; }

        public PaintingController()
        {
            Paintings = new List<Painting>()
            {
                new Painting() {Id = 1, Name = "Рождение Венеры", Artist ="Сандро Боттичели", Genre = "Мифологический жанр", PaintingTechnique = "Темпера"},
                new Painting() {Id = 2, Name = "Девятый вал", Artist ="Иван Айвазовский", Genre = "Марина", PaintingTechnique = "Масло"},
                new Painting() {Id = 3, Name = "Заяц", Artist ="Альбрехт Дюрер", Genre = "Анималистика", PaintingTechnique = "Акварель, гуашь, белила"},
                new Painting() {Id = 4, Name = "Последний день Помпеи", Artist ="Карл Брюллов", Genre = "Исторический жанр", PaintingTechnique = "Масло"},
                new Painting() {Id = 5, Name = "Мона Лиза", Artist ="Леонардо да Винчи", Genre = "Портрет", PaintingTechnique = "Масло"}
                
            };
        }
        [HttpGet]
        public ActionResult GetAllPaintings()
        {
            return Ok(Paintings);
        }
    }
}
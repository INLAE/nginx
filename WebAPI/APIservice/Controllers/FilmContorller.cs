using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WepAppLinux.Models;

namespace WepAppLinux.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookContoller : ControllerBase
    {
        private List<Book> Books { get; set; }

        public BookContoller()
        {
            Books = new List<Book>()
            {
                new Book() {Id = 1, Name = "Крёстный отец", Author ="Марио Пьюзо", Genre = "Криминальный детектив", PublishingHouse = "ЭКСМО"},
                new Book() {Id = 2, Name = "Метро 2033", Author ="Дмитрий Глуховский", Genre = "Постапокалиптика", PublishingHouse = "ЭКСМО"},
                new Book() {Id = 3, Name = "Мартин Иден", Author ="Джек Лондон", Genre = "Драма", PublishingHouse = "АСТ"},
                new Book() {Id = 4, Name = "Поющие в терновнике", Author ="Колин Маккалоу", Genre = "Роман-семейная сага", PublishingHouse = "АСТ"},
                new Book() {Id = 5, Name = "Три товарища", Author ="Эрих Мария Ремарк", Genre = "Роман", PublishingHouse = "АСТ"}
            };
        }
        [HttpGet]
        public ActionResult GetAllBooks()
        {
            return Ok(Books);
        }
    }
}
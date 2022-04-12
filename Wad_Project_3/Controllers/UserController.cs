using Microsoft.AspNetCore.Mvc;
using Wad_Project_3.Data;
using Wad_Project_3.Models;

namespace Wad_Project_3.Controllers
{
    public class UserController : Controller
    {
        private readonly Aplication _db;
        public UserController(Aplication db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(User obj) 
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

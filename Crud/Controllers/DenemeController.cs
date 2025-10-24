using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Data;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Controllers
{
    public class DenemeController : Controller
    {
        private readonly CrudContext _context;

        public DenemeController(CrudContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email)
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email,
                Phone = "555-0000",
                Subscribed = false
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            ViewBag.Message = "Kayıt başarılı!";
            return View();
        }
    }
}

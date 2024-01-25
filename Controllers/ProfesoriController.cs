using examenDAW.Models;
using Microsoft.AspNetCore.Mvc;
using examenDAW.Migrations;
using Microsoft.AspNetCore.Identity;

namespace examenDAW.Controllers
{
    

    public class ProfesoriController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProfesoriController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var profi = db.Profesori;

            ViewBag.Profesori = profi;

            return View();
        }
        public IActionResult New()
        {
            Profesor prof = new Profesor();
            return View(prof);
        }

        [HttpPost]
        public IActionResult New(Profesor prof)
        {
            if(ModelState.IsValid)
            {
                db.Profesori.Add(prof);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(prof);
            }
        }
    }
}

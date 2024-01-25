using examenDAW.Models;
using Microsoft.AspNetCore.Mvc;

namespace examenDAW.Controllers
{
    public class MateriiControler : Controller
    {
        private readonly ApplicationDbContext db;

        public MateriiControler(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var mat = db.Materii;

            ViewBag.Materii = mat;

            return View();
        }
        public IActionResult New()
        {
            Materie mat = new Materie();
            return View(mat);
        }

        [HttpPost]
        public IActionResult New(Materie mat)
        {
            if (ModelState.IsValid)
            {
                db.Materii.Add(mat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(mat);
            }
        }
    }
}

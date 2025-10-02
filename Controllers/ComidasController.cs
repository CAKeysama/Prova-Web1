using Microsoft.AspNetCore.Mvc;
using ProvaWeb1.Models;
using System.Linq;

namespace ProvaWeb1.Controllers
{
    public class ComidasController : Controller
    {
        private readonly AppDbContext _context;

        public ComidasController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var comidas = _context.Comidas.ToList();
            return View(comidas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Comida comida)
        {
            if (ModelState.IsValid)
            {
                _context.Comidas.Add(comida);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(comida);
        }

        public IActionResult Edit(int id)
        {
            var comida = _context.Comidas.Find(id);
            if (comida == null) return NotFound();
            return View(comida);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Comida comida)
        {
            if (ModelState.IsValid)
            {
                _context.Comidas.Update(comida);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(comida);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("O ID da comida é obrigatório.");
            }

            var comida = _context.Comidas.FirstOrDefault(c => c.Id == id);
            if (comida == null)
            {
                return NotFound("Comida não encontrada.");
            }

            return View(comida);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var comida = _context.Comidas.Find(id);
            if (comida == null) return NotFound();

            _context.Comidas.Remove(comida);
            _context.SaveChanges();
            return View("DeleteConfirmed");
        }
    }
}
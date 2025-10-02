using Microsoft.AspNetCore.Mvc;
using ProvaWeb1.Models;
using System.Linq;

namespace ProvaWeb1.Controllers
{
    public class FilmesController : Controller
    {
        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var filmes = _context.Filmes.ToList();
            return View(filmes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Filme filme)
        {
            if (ModelState.IsValid)
            {
                _context.Filmes.Add(filme);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(filme);
        }

        public IActionResult Edit(int id)
        {
            var filme = _context.Filmes.Find(id);
            if (filme == null) return NotFound();
            return View(filme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Filme filme)
        {
            if (ModelState.IsValid)
            {
                _context.Filmes.Update(filme);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(filme);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("O ID do filme é obrigatório.");
            }

            var filme = _context.Filmes.FirstOrDefault(f => f.Id == id);
            if (filme == null)
            {
                return NotFound("Filme não encontrado.");
            }

            return View(filme);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var filme = _context.Filmes.Find(id);
            if (filme == null) return NotFound();

            _context.Filmes.Remove(filme);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
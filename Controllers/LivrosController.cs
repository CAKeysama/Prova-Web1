using Microsoft.AspNetCore.Mvc;
using ProvaWeb1.Models;
using System.Linq;

namespace ProvaWeb1.Controllers
{
    public class LivrosController : Controller
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var livros = _context.Livros.ToList();
            return View(livros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Livros.Add(livro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        public IActionResult Edit(int id)
        {
            var livro = _context.Livros.Find(id);
            if (livro == null) return NotFound();
            return View(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Livros.Update(livro);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("O ID do livro é obrigatório.");
            }

            var livro = _context.Livros.FirstOrDefault(l => l.Id == id);
            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }

            return View(livro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var livro = _context.Livros.Find(id);
            if (livro == null) return NotFound();

            _context.Livros.Remove(livro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
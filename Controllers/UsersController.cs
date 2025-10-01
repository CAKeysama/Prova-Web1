using Microsoft.AspNetCore.Mvc;
using ProvaWeb1.Models;
using System.Linq;

namespace ProvaWeb1.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        // Injetamos o banco (DbContext) via construtor
        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // LISTAR todos os usuários
        public IActionResult Index()
        {
            var usuarios = _context.Users.ToList();
            return View(usuarios);
        }

        // GET - Criar novo usuário (abre formulário)
        public IActionResult Create()
        {
            return View();
        }

        // POST - Criar novo usuário (recebe os dados do form)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET - Editar usuário
        public IActionResult Edit(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        // POST - Editar usuário
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET - Excluir usuário (confirmação)
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        // POST - Excluir usuário (executa a exclusão)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

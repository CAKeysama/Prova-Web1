using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProvaWeb1.Models
{
    // DbContext é a "ponte" entre a aplicação e o banco de dados
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet representa uma tabela do banco
        public DbSet<User> Users { get; set; }
    }
}

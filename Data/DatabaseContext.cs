
using Microsoft.EntityFrameworkCore;
using ProjetoCadastroMVC.Models;

namespace ProjetoCadastroMVC.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}

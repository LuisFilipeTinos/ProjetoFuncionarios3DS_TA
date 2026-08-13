using ProjetoCadastroMVC.Data;
using ProjetoCadastroMVC.Models;

namespace ProjetoCadastroMVC.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DatabaseContext dbContext;

        public FuncionarioRepository(DatabaseContext contexto)
        {
            dbContext = contexto;
        }

        public List<Funcionario> BuscarTodos()
        {
            return dbContext.Funcionarios.ToList();
        }
    }
}

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

        public Funcionario Adicionar(Funcionario funcionario)
        {
            dbContext.Funcionarios.Add(funcionario);
            dbContext.SaveChanges();
            return funcionario;
        }

        public Funcionario BuscarPorId(int id)
        {
            return dbContext.Funcionarios.FirstOrDefault(x => x.Id == id);
        }

        public Funcionario Atualizar(Funcionario funcionario)
        {
            Funcionario func = BuscarPorId(funcionario.Id);

            if (func == null)
            {
                throw new Exception("Houve um problema ao atualizar!");
            }

            func.Nome = funcionario.Nome;
            func.Cargo = funcionario.Cargo;
            func.CPF = funcionario.CPF;
            func.Departamento = funcionario.Departamento;
            func.Salario = funcionario.Salario;

            dbContext.Funcionarios.Update(func);
            dbContext.SaveChanges();

            return func;
        }
    }
}

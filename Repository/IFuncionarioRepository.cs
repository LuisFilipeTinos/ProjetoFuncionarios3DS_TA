using ProjetoCadastroMVC.Models;

namespace ProjetoCadastroMVC.Repository
{
    public interface IFuncionarioRepository
    {
        List<Funcionario> BuscarTodos();
        Funcionario Adicionar(Funcionario funcionario);
    }
}

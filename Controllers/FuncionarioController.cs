using Microsoft.AspNetCore.Mvc;
using ProjetoCadastroMVC.Models;
using ProjetoCadastroMVC.Repository;

namespace ProjetoCadastroMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository funcRep;

        public FuncionarioController(IFuncionarioRepository funcReposi)
        {
            funcRep = funcReposi;
        }

        public IActionResult Index()
        {
            List<Funcionario> listaFuncionarios = funcRep.BuscarTodos();
            return View(listaFuncionarios);
        }
    }
}

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

        public IActionResult Criar()
        {
            ViewBag.TipoTela = "Criar";
            return View("~/Views/Funcionario/CriarEditar.cshtml");
        }

        public IActionResult Editar(int id)
        {
            Funcionario funcionario = funcRep.BuscarPorId(id);
            ViewBag.TipoTela = "Editar";
            return View("~/Views/Funcionario/CriarEditar.cshtml", funcionario);
        }

        [HttpPost]
        public IActionResult Criar(Funcionario funcionario)
        {
            funcRep.Adicionar(funcionario);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Funcionario funcionario)
        {
            funcRep.Atualizar(funcionario);
            return RedirectToAction("Index");
        }

    }
}

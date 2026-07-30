using Microsoft.AspNetCore.Mvc;

namespace ProjetoCadastroMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

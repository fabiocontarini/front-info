using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class RhController : Controller
    {
        public IActionResult Index(int especialidadeId, string especialidadeNome)
        {
            // Passa os parâmetros para a View, se precisar usar no cshtml
            ViewData["EspecialidadeId"] = especialidadeId;
            ViewData["EspecialidadeNome"] = especialidadeNome;

            return View();
        }
    }
}

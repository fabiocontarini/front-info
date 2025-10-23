using Auth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*[Authorize(Roles =  "Admin, TI")]*/
        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult EditarPerfil()
        {
            return View();
        }


        /* [Authorize(Roles = "Admin, Rh")]
        public IActionResult Rh()
        {
            return View();
        } */

        public IActionResult Medicos(int especialidadeId, string especialidadeNome)
        {
            ViewData["EspecialidadeId"] = especialidadeId;
            ViewData["EspecialidadeNome"] = especialidadeNome;

            return View();
        }

       /* [Authorize(Roles = "Admin, Financeiro")]*/
        public IActionResult Financeiro()
        {
            return View();
        }

       /* [Authorize(Roles = "Admin, Comercial")]*/
        public IActionResult AreaMedico()
        {
            return View();
        }

        public IActionResult Especialidades()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase
    {
    }
}

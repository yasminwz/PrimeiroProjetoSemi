using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoSemi.Models;
using System.Diagnostics;

namespace PrimeiroProjetoSemi.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem()
        {
            List<string> nomes= new List<string>();
            nomes.Add("Algeu");
            nomes.Add("Edjalma");
            nomes.Add("Leonardo");
            return View(nomes);
        }

        public IActionResult Contador()
        {
            Quantidade.numeroDeAcessos = Quantidade.numeroDeAcessos + 1;
            return View(Quantidade.numeroDeAcessos);


        }

        public IActionResult ZerarContador()
        {
            Quantidade.numeroDeAcessos = 0;
                return RedirectToAction("Contador");
        }

        public IActionResult Contato()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
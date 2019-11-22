using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models.ViewModel;

namespace Projeto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["H1"] = "Sejam Bem Vindos!";
            ViewData["H2"] = "Projeto Desafio QSTI";
            ViewData["Message"] = "Desenvolvedor: Francisco Luiz";
            ViewData["Email"] = "flsdrj@hotmail.com";
            return View(ViewData);
        }

        public IActionResult Privacy()
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

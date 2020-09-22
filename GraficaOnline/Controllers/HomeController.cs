using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GraficaOnline.Models;
using GraficaOnline.Repositories;
using GraficaOnline.ViewModels;

namespace GraficaOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosPreferidos = _produtoRepository.ProdutosPreferidos
            };
            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
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

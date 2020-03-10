using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeusFilmes.UI.Models;
using MeusFilmes.Business.Interfaces.Repositories;

namespace MeusFilmes.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFilmeRepository _filmeRepository;

        public HomeController(ILogger<HomeController> logger, IFilmeRepository filmeRepository)
        {
            _logger = logger;
            _filmeRepository = filmeRepository;
        }

        public IActionResult Index()
        {
            var model = _filmeRepository.Consultar();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using MGL7760POC.Abstraction.Services;
using MGL7760POC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MGL7760POC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDeclarationService _declarationService;
        public HomeController(ILogger<HomeController> logger, IDeclarationService declarationService)
        {
            _logger = logger;
            _declarationService = declarationService;
        }

        public IActionResult Index()
        {
            var declarations = _declarationService.GetDeclarations();
            return View(declarations);
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

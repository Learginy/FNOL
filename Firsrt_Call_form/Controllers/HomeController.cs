using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Firsrt_Call_form.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Firsrt_Call_form.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AllSimptoms _allSimptoms;
        private ILogger<HomeController> _logger;
        public HomeController(IOptions<AllSimptoms> allSimptoms, ILogger<HomeController> logger)
        {
            _allSimptoms = allSimptoms.Value;
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.AllSimpthoms = _allSimptoms.Items;

            return View(new FirstCallModel());
        }

        [HttpPost]
        public IActionResult SendToCrm(FirstCallModel model)
        {
            _logger.Log(LogLevel.Information, $"Пользователь {User.Identity.Name} прислал форму");
            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PMIDE.Models;
using PMIDE.Models.Task;

namespace PMIDE.Controllers
{
    public class TaskController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TaskController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string id)
        {
            TaskPageModel result = new TaskPageModel("Task page : " + id);

            return View(result);
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

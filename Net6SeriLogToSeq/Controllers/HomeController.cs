using Microsoft.AspNetCore.Mvc;
using Net6SeriLogToSeq.Models;
using System.Diagnostics;

namespace Net6SeriLogToSeq.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            string firstLog = "First Log!";
            _logger.LogInformation("Hello {firstLog}", firstLog);
        }

        public IActionResult Index()
        {
            _logger.LogError("Hello! Index LogError");
            _logger.LogWarning("Hello! Index LogWarning");
            _logger.LogTrace("Hello! Index LogTrace");
            _logger.LogInformation("Hello! Index LogInformation");
            return View();
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
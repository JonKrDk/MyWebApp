using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Diagnostics;

namespace MyWebApp.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyView()
        {
            _logger.LogDebug("MyView()");
            return View();
        }

        public IActionResult EnterText()
        {
            _logger.LogDebug("EnterText()");
            return View();
        }

        public IActionResult ShowText(TextModel textModel)
        {
            _logger.LogDebug($"ShowText(textModel={textModel})");

            if (textModel.InText != "")
            {
                textModel.OutText = "";
                foreach (char c in textModel.InText)
                {
                    textModel.OutText = c + textModel.OutText;
                }
            }

            return View(textModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
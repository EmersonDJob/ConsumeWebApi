using ConsumeWebApi.Interface;
using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConsumeWebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IApiConnect    _connect;

        public HomeController(ILogger<HomeController> logger, IApiConnect apiConnect)
        {
            _logger = logger;
            _connect = apiConnect;
        }

        public  async Task<IActionResult> Index()
        {
            var getAll = await _connect.ConnectAsync();
            return View(getAll);
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
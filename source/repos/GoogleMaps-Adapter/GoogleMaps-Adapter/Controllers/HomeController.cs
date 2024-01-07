using GoogleMaps_Adapter.Models;
using GoogleMaps_Adapter.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoogleMaps_Adapter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICoordinateService coordinateService;
        private readonly IGoogleMapAdapter mapAdapter;

        public HomeController(ILogger<HomeController> logger, ICoordinateService coordinateService,
            IGoogleMapAdapter mapAdapter)
        {
            _logger = logger;
            this.coordinateService = coordinateService;
            this.mapAdapter = mapAdapter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetCoordinates()
        {
            var coordinates = coordinateService.GetCoordinates();
            mapAdapter.ProcessCoordinates(coordinates);
            return View(coordinates);
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

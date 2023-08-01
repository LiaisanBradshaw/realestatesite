using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
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
            FeaturedHousesVModel featuredHousesVModel=new FeaturedHousesVModel();


            return View(featuredHousesVModel);
        }

        public IActionResult Buy(bool highLow=false, bool lowHigh=false)

        {
            BuyViewModel buyViewModel=new BuyViewModel();

            if (highLow)
            {
                buyViewModel.Buy= buyViewModel.Buy.ToList().OrderByDescending(x => x.Price).ToList();
            }

            if (lowHigh)
            {
                buyViewModel.Buy = buyViewModel.Buy.ToList().OrderBy(x => x.Price).ToList();
            }

            return View(buyViewModel);
        }

        public IActionResult Rent(bool highLow = false, bool lowHigh = false)

        {
            RentViewModel rentViewModel = new RentViewModel();

            if (highLow)
            {
                rentViewModel.rent = rentViewModel.rent.ToList().OrderByDescending(x => x.Price).ToList();
            }

            if (lowHigh)
            {
                rentViewModel.rent = rentViewModel.rent.ToList().OrderBy(x => x.Price).ToList();
            }

            return View(rentViewModel);
        }

        public IActionResult Contact()

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
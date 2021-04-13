using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCore_DI.Models;
using NetCore_DI.Models.ViewModels;
using NetCore_DI.Services;

namespace NetCore_DI.Controllers
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
            HomeVM hVm = new HomeVM();
            MarketForecaster mForecaster = new MarketForecaster();
            var currentMarket = mForecaster.GetMarketPrediction();
            switch(currentMarket.MarketCondition)
            {
                case MarketCondition.StableDown:
                    hVm.MarketForecast ="It's crashing down!!!!";
                    break;
                case MarketCondition.Volatile:
                    hVm.MarketForecast ="It's all over the place!";
                    break;
                case MarketCondition.StableUp:
                    hVm.MarketForecast ="Bull run jump aboard";
                    break;
                default:
                    hVm.MarketForecast ="What's going on here!!!";
                    break;                                                            
            }
            return View(hVm);
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

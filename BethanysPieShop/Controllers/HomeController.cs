using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;

namespace BethanysPieShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPieRepository _pieRepository;

    public HomeController(IPieRepository pieRepository, ILogger<HomeController> logger)
    {
        _logger = logger;
         _pieRepository = pieRepository;
    }

    
        public ViewResult Index()
        {
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;

            var homeViewModel = new HomeViewModel(piesOfTheWeek);

            return View(homeViewModel);
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


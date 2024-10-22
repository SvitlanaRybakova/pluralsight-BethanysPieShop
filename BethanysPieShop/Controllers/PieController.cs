using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BethanysPieShop.Controllers
{

    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        // private readonly ILogger<PieController> _logger;
        private readonly ILogger<PieListViewModel> _pieListLogger;


        // DI example (inject to constructor)
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository, ILogger<PieListViewModel> pieListLogger)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
            _pieListLogger = pieListLogger;
        }

        public IActionResult List()
        {
            // ViewBag.CurrentCategory = "Cheese cakes";
            // return View(_pieRepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes", _pieListLogger);
            return View(pieListViewModel);
        }

    }
}
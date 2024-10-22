using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; }
        public string? CurrentCategory { get; }

        private readonly ILogger<PieListViewModel> _logger;

        public PieListViewModel(IEnumerable<Pie> pies, string currentCategory, ILogger<PieListViewModel> logger)

        {
            Pies = pies;
            CurrentCategory = currentCategory;
            _logger = logger;


            _logger.LogInformation("CurrentCategory: {CurrentCategory}, Length: {Length}", currentCategory, currentCategory.Length);
        }
    }
}
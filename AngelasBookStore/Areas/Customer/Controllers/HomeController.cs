using AngelasBooks.DataAccess.Repository.IRepository;
using AngelasBooks.Models;
using AngelasBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AngelasBookStore.Area.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller     
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;               // Added based on the comparison with the provided repository

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)           // Added IUnitOfWork unitOfWork based on the comparison with the provided repository
        {
            _logger = logger;
            _unitOfWork = unitOfWork;           // Added based on the comparison with the provided repository
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category, CoverType");        // Added based on the comparison with the provided repository
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

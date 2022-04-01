using CoreBusiness.Concrete.Concrete;
using CoreData.Concrete.Repositories;
using CoreMvcUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CoreMvcUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductManager pm = new ProductManager(new EfProductRepository());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public  IActionResult Index()
        {
            var val = pm.GetAll();
            return View(val);
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

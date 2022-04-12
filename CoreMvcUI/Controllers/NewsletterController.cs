using CoreBusiness.Concrete.Concrete;
using CoreData.Concrete.Repositories;
using CoreEntity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcUI.Controllers
{
    public class NewsletterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpGet]
        public PartialViewResult Index()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Index(NewsLetter letter)
        {
            nm.Add(letter);
            return PartialView();
        }
    }
}

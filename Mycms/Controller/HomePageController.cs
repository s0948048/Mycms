using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controller
{
    public class HomePageController: PageController<HomePage>
    {
        public ActionResult Index(HomePage currentPage)
        {
            return View(currentPage);
        }
    }
}

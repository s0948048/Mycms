using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controllers.Pages
{
    public class GeneralPageController : BasePageController<GeneralPage>
    {
        public IActionResult Index(GeneralPage currentPage)
        {

            // passing viewmodel to the view.
            return PageView(currentPage);
        }
    }
}

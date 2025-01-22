using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controllers.Pages
{
    public class NewsItemPageController : BasePageController<NewsItemPage>
    {
        public IActionResult Index(NewsItemPage currentPage)
        {
            return PageView(currentPage);
        }
    }
}

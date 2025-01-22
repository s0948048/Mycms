using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;
using Mycms.Models.Pages.ViewModels;

namespace Mycms.Controllers.Pages
{
    public class HomePageController : BasePageController<HomePage>
    {
        private readonly IContentLoader _contentLoader;

        public HomePageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IActionResult Index(HomePage currentPage)
        {
            var viewModel = new HomePageViewModel(currentPage);

            var childPages = _contentLoader.GetChildren<AbstractPage>(currentPage.ContentLink);

            viewModel.RelatedContent = childPages;
            return PageView(viewModel);
        }


    }
}

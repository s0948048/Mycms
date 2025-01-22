using EPiServer.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;
using Mycms.Models.Pages.ViewModels;

namespace Mycms.Controllers.Pages
{
    public class NewsPageController : BasePageController<NewsPage>
    {
        private readonly IContentLoader _contentLoader;

        public NewsPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        [AcceptVerbs("GET")]
        public IActionResult Index(NewsPage currentPage,int Page=0)
        {
            var viewModel = new NewsPageViewModel(currentPage);

            var newsList = _contentLoader.GetChildren<NewsItemPage>(currentPage.ContentLink)
                .Skip(Page * 6)
                .Take(6);

            viewModel.newlist = newsList;

            return PageView(viewModel);
        }
    }
}

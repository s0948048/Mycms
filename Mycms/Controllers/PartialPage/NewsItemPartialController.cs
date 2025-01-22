using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controllers.PartialPage
{
    public class NewsItemPartialController : BasePartialController<NewsItemPage>
    {
        protected override IViewComponentResult InvokeComponent(NewsItemPage currentContent)
        {
            return base.InvokeComponent(currentContent);
        }
    }
}

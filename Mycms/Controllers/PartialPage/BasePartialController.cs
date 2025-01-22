using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controllers.PartialPage
{
    public class BasePartialController<T> : PartialContentComponent<T> where T : AbstractPage
    {
        protected override IViewComponentResult InvokeComponent(T currentContent)
        {
            return View($"~/Views/PartialPages/{typeof(T).Name}.cshtml", currentContent);
        }
    }
}

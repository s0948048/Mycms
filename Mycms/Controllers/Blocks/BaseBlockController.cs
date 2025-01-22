using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Mycms.Controllers.Blocks
{
    public class BaseBlockController<T>:BlockComponent<T> where T : BlockData
    {
        protected override IViewComponentResult InvokeComponent(T currentBlock)
        {
            return View($"~/Views/Blocks/{typeof(T).Name}.cshtml", currentBlock);
        }
    }
}

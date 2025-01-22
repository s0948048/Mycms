using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Blocks;

namespace Mycms.Controllers.Blocks
{
    public class LinkGridBlockController : BaseBlockController<LinkGridBlock>
    {
        protected override IViewComponentResult InvokeComponent(LinkGridBlock currentContent)
        {
            return base.InvokeComponent(currentContent);
        }
    }
}

using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Blocks;

namespace Mycms.Controllers.Blocks
{
    public class SectionMediaBlockController : BaseBlockController<SectionMediaBlock>
    {
        protected override IViewComponentResult InvokeComponent(SectionMediaBlock currentContent)
        {
            return base.InvokeComponent(currentContent);
        }
    }
}

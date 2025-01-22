using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Mycms.Models.Pages;

namespace Mycms.Controllers.PartialPage
{

    /// <summary>
    /// Partial controller for the AbstractPage.
    /// if AbstractPage call by contentArea in a page, this controller will be called.
    /// </summary>
    public class AbstractPagePartialContoller : BasePartialController<AbstractPage>
    {
        protected override IViewComponentResult InvokeComponent(AbstractPage currentContent)
        {
            return base.InvokeComponent(currentContent);
        }
    }


    // 下方為測試 TemplateDescriptor 的程式碼
    #region
    /*8<------------------------------------>
    /// <summary>
    /// Partial controller for the AbstractPage.
    /// if AbstractPage call by contentArea in a page, this controller will be called.
    /// </summary>
    [TemplateDescriptor]
    public class MyAbstractPagePartialContoller : BasePartialController<AbstractPage>
    {
        protected override IViewComponentResult InvokeComponent(AbstractPage currentContent)
        {
            return View($"~/Views/PartialPages/{typeof(AbstractPage).Name}-noIn.cshtml", currentContent);
            //return base.InvokeComponent(currentContent);
        }
    }

    /// <summary>
    /// Partial controller for the AbstractPage.
    /// if AbstractPage call by contentArea in a page, this controller will be called.
    /// </summary>
    [TemplateDescriptor(Inherited = true)]
    public class AbstractPageFallBackPartialContoller : BasePartialController<AbstractPage>
    {
        protected override IViewComponentResult InvokeComponent(AbstractPage currentContent)
        {
            return View($"~/Views/PartialPages/{typeof(AbstractPage).Name}-In.cshtml", currentContent);
            //return base.InvokeComponent(currentContent);
        }
    }

    /// <summary>
    /// When Detection for phone, this controller will be called.
    /// Partial controller for the AbstractPage.
    /// if AbstractPage call by contentArea in a page, this controller will be called.
    /// </summary>
    [TemplateDescriptor(Tags = ["phone"])]
    public class AbstractPagePhonePartialContoller : BasePartialController<AbstractPage>
    {
        protected override IViewComponentResult InvokeComponent(AbstractPage currentContent)
        {
            return View($"~/Views/PartialPages/{typeof(AbstractPage).Name}-phone-noIn.cshtml", currentContent);
            //return base.InvokeComponent(currentContent);
        }
    }

    [TemplateDescriptor(Tags = ["phone"],Inherited = true)]
    public class AbstractPagePhoneFallBackPartialContoller : BasePartialController<AbstractPage>
    {
        protected override IViewComponentResult InvokeComponent(AbstractPage currentContent)
        {
            return View($"~/Views/PartialPages/{typeof(AbstractPage).Name}-phone-In.cshtml", currentContent);
            //return base.InvokeComponent(currentContent);
        }
    }
    */
    #endregion
}

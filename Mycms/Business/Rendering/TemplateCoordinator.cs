using EPiServer.DataAbstraction.RuntimeModel.Internal;
using EPiServer.Framework.Web;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Mycms.Models.Blocks;
using Mycms.Models.Pages;

namespace Mycms.Business.Rendering
{
    //[ServiceConfiguration]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            /*
            RegisterAbstractPage<SectionMediaBlock>(viewTemplateModelRegistrator, "Block");
            RegisterAbstractPage<LinkGridBlock>(viewTemplateModelRegistrator, "Block");
            */


            /*
            // 沒有Tag，衍伸類別無法使用。
            // 指定Tag => 讓AbstractPage的衍伸類別可以使用。
            viewTemplateModelRegistrator.Add(typeof(AbstractPage), new TemplateModel
            {
                Name = "AbstractPage-Partial",
                AvailableWithoutTag = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractPage/Index.cshtml"
            });

            // 沒有Tag，直接指定類別。
            viewTemplateModelRegistrator.Add(typeof(HomePage), new TemplateModel
            {
                Name = "HomePage-Partial",
                AvailableWithoutTag = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = "~/Views/AbstractPage/Index.cshtml"
            });
            */
        }

        private void RegisterAbstractPage<T>(TemplateModelCollection viewTemplateModelRegistrator,string type) where T : IContentData
        {
            viewTemplateModelRegistrator.Add(typeof(T), new TemplateModel
            {
                Name = $"{typeof(T).Name}-{type}",
                AvailableWithoutTag = true,
                TemplateTypeCategory = TemplateTypeCategories.MvcPartialView,
                Path = $"~/Views/{type}/{typeof(T).Name}.cshtml"
            });
        }
    }
}

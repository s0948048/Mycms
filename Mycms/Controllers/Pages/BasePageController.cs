using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mycms.Models.Pages;
using Mycms.Models.Pages.ViewModels;

namespace Mycms.Controllers.Pages
{
    public abstract class BasePageController<T>:PageController<T> where T : AbstractPage
    {

        /// <summary>
        /// return a view with passsing pageModel and transfer to ViewModel.
        /// </summary>
        /// <param name="pageModel"></param>
        /// <returns></returns>
        protected IActionResult PageView(T pageModel)
        {
            var viewModel = new PageViewModel<T>(pageModel);

            return PageView(viewModel);
        }


        protected IActionResult PageView(PageViewModel<T> viewModel)
        {
            viewModel.Title = string.IsNullOrEmpty(viewModel.Page.PageTitle) ? viewModel.Page.Name : viewModel.Page.PageTitle;

            return View($"~/Views/Pages/{typeof(T).Name}.cshtml", viewModel);
        }
    }
}


namespace Mycms.Models.Pages.ViewModels
{
    public class HomePageViewModel : PageViewModel<HomePage>
    {
        public HomePageViewModel(HomePage currentPage) : base(currentPage)
        {
        }

        public IEnumerable<AbstractPage> RelatedContent { get; internal set; } = [];
    }
}

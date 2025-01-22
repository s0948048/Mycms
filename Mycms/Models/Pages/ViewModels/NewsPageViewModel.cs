namespace Mycms.Models.Pages.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {

        public NewsPageViewModel(NewsPage page) : base(page)
        {
        }

        public int PagesCount { get; set; }

        public IEnumerable<NewsItemPage>? newlist { get; set; } = [];
    }
}

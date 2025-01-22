using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace Mycms.Models.Pages
{
    [ContentType(
        DisplayName = "News Item Page.",
        GUID = "2189ee3c-cf3e-4338-a604-f7f88f0faada")]
    public class NewsItemPage: AbstractPage
    {
        [Display(
            Name = "News Title",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual string? NewsTitle { get; set; }

        [Display(
            Name = "News Body",
            GroupName = SystemTabNames.Content,
            Order = 22)]
        public virtual XhtmlString? NewsBody { get; set; }

        [Display(Name = "News Image",
            GroupName = SystemTabNames.Content,
            Order = 23)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference? NewsImage { get; set; }
    }
}

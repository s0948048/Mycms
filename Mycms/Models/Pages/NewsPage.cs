using Mycms.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace Mycms.Models.Pages
{
    [ContentType(
        DisplayName ="News Lists Page.",
        GroupName = "Normal",
        GUID = "f5813127-207d-47e5-8d0e-5d96d9e3ca6b")]
    public class NewsPage:AbstractPage
    {
        [Display(
            Name = "headline text.",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual string? HeadLine { get; set; }

        [Display(
            Name = "head slug text.",
            GroupName = SystemTabNames.Content,
            Order = 22)]
        public virtual string? HeadLineSlug { get; set; }

        [Display(
            Name = "Body content.",
            GroupName = SystemTabNames.Content,
            Order = 23)]
        public virtual XhtmlString? body { get; set; }

        [Display(
            Name = "Bottom content area.",
            GroupName = SystemTabNames.Content,
            Order = 24)]
        [AllowedTypes([typeof(NewsItemPage)])]
        public virtual ContentArea? NewListArea { get; set; }
    }
}

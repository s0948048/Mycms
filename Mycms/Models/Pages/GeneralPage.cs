using System.ComponentModel.DataAnnotations;

namespace Mycms.Models.Pages
{
    [ContentType(
        DisplayName = "General page.",
        GUID = "89c08b3a-4413-41cf-a53d-c71851a190b6")]
    public class GeneralPage:AbstractPage
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
    }
}

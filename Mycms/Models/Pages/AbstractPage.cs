using System.ComponentModel.DataAnnotations;

namespace Mycms.Models.Pages
{
    [ContentType(
        DisplayName = "Abstract page.",
        GUID = "b1b1b1b1-b1b1-b1b1-b1b1-b1b1b1b1b1b1"
        )]
    public abstract class AbstractPage:PageData
    {
        [Display(
       Name = "Page title.",
       GroupName = "SEO",
       Order = 11)]
        public virtual string? PageTitle { get; set; }

        [Display(
            Name = "Page Meta description.",
            GroupName = "SEO",
            Order = 12)]
        public virtual string? MetaDescription { get; set; }
    }
}

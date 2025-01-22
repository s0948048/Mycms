using System.ComponentModel.DataAnnotations;
using Mycms.Models.Pages;

namespace Mycms.Models.Blocks
{
    /// <summary>
    /// Block for a grid of links.
    /// Input Specific content of links.
    /// </summary>
    [ContentType(
        DisplayName = "Link Grid Block",
        GUID = "f1f1b1b1-1b1b-1b1b-1b1b-1b1b1b1b1b1b")]
    public class LinkGridBlock:BlockData
    {
        [Display(
            Name = "Links",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [AllowedTypes([typeof(AbstractPage)])]
        public virtual ContentArea? Links{ get; set; }
    }
}

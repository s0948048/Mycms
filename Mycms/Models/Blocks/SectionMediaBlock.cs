using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace Mycms.Models.Blocks
{
    /// <summary>
    /// Basic Block for a section with a media element.
    /// with single Layer ContentArea.
    /// </summary>
    [ContentType(DisplayName = "Section Media Block", 
        GUID = "f1b1b1b1-1b1b-1b1b-1b1b-1b1b1b1b1b1b")]
    public class SectionMediaBlock:BlockData
    {
        [Display(Name = "Block head line",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? HeadLine { get; set; }

        [Display(Name = "Block body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString? Body { get; set; }

        [Display(Name = "Image",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [UIHint(uiHint:UIHint.Image)]
        public virtual ContentReference? Image { get; set; }
    }
}

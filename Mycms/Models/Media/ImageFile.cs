using System.ComponentModel.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Mycms.Models.Media
{
    [ContentType(
        DisplayName = "Image File", 
        GUID = "f3b3b3b3-3b3b-3b3b-3b3b-3b3b3b3b3b3b", 
        Description = "Image File")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,gif,bmp,png")]
    public class ImageFile:ImageData
    {
        [Display(
            Name = "Alternative text"
            )]
        public virtual string? AltText { get; set; }
    }
}

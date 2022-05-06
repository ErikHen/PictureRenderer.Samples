using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace OptimizelyCMS_empty.Models.Pages
{
    [ContentType(DisplayName = "Standard page", GUID = "934E7266-F123-4DEA-B033-3B4E6AE6CBCF", AvailableInEditMode = true)]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string Title { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 2)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TestImage1 { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body", GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString MainBody { get; set; }
    }
}

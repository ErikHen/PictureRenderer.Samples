using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace OptimizelyCMS_empty.Models.Pages
{
    [ContentType(DisplayName = "Standard page", GUID = "934E7266-F123-4DEA-B033-3B4E6AE6CBCF", AvailableInEditMode = true)]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(Name = "Title", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "Main body", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual XhtmlString MainBody { get; set; }
    }
}

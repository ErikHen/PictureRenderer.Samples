using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace OptimizelyCMS.Models
{
    [ContentType(GUID = "19671657-B684-4D95-A61F-8DD4FE60D559", GroupName = GroupNames.Specialized)]
    public class StartPage : SitePageData
    {

        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TestImage1 { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 110)]
        public virtual XhtmlString SomeRichText { get; set; }


        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

    }
}
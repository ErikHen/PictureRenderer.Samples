using System.ComponentModel.DataAnnotations;
using EPiServer.DataAnnotations;

namespace OptimizelyCMS
{
    [GroupDefinitions()]
    public static class GroupNames
    {
        [Display(Name = "Metadata", Order = 11)]
        public const string MetaData = "Metadata";

        [Display(Name = "Specialized", Order = 7)]
        public const string Specialized = "Specialized";
    }
}

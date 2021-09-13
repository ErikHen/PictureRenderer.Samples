using EPiServer.Web.Mvc;
using OptimizelyCMS.Models;

namespace OptimizelyCMS.Controllers
{
    /// <summary>
    /// All controllers that renders pages should inherit from this class so that we can
    /// apply action filters, such as for output caching site wide, should we want to.
    /// </summary>
    public abstract class PageControllerBase<T> : PageController<T> 
        where T : SitePageData
    {

      
    }
}

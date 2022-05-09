using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCMS_empty.Models.Pages;

namespace OptimizelyCMS_empty.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        [HttpGet]
        public IActionResult Index(StandardPage currentPage)
        {
            return View(currentPage);
        }
    }
}

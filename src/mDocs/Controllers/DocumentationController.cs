using Microsoft.AspNetCore.Mvc;

namespace mDocs.Controllers
{
    public class DocumentationController : Controller
    {
        [Route("/{*url}")]
        public IActionResult Index(string url)
        {
            if (url == null || url.EndsWith("/"))
            {
                url += "Index";
            }

            return View(url);
        }
    }
}

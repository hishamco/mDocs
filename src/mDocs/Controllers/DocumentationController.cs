using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mDocs.Controllers
{
    public class DocsController : Controller
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

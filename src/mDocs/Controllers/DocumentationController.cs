using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mDocs.Controllers
{
    public class DocsController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

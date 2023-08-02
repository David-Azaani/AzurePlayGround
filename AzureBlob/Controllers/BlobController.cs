using Microsoft.AspNetCore.Mvc;

namespace AzureBlob.Controllers;

    public class BlobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }


using Microsoft.AspNetCore.Mvc;

namespace AzureBlob.Controllers;

    public class ContainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }


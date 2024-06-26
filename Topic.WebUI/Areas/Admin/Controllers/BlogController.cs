using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace Topic.WebUI.Areas.Admin.Controllers
{
    public class BlogController : Controller
    {
        private readonly HttpClient _client;

        public BlogController(HttpClient client)
        {
            client.BaseAddress = new Uri("");
            _client = client;
        }

        public async  Task<IActionResult> Index()
        {
            return View();
        }
    }
}

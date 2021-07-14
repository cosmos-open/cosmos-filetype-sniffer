using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Cosmos.Business.Samples.Models;
using Cosmos.Sniffers;
using Microsoft.AspNetCore.Hosting;

namespace Cosmos.Business.Samples.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IFileTypeSniffer _sniffer;

        public HomeController(IWebHostEnvironment env, IFileTypeSniffer sniffer)
        {
            _env = env;
            _sniffer = sniffer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sniffer()
        {
            var path = _env.WebRootFileProvider.GetFileInfo("img/sniffer.jpg").PhysicalPath;
            byte[] array = new byte[20];
            using (var file = System.IO.File.Open(path, FileMode.Open))
            {
                file.Read(array, 0, array.Length);
            }

            var results = _sniffer.Match(array, true);
            var statistics = _sniffer.GetMetadataStatistics();
            var content = $@"
statistics: total={statistics.Total}
result: {results.ToListString()}
";
            return Content(content);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
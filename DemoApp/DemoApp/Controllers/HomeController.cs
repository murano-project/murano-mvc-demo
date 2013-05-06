using System;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web.Mvc;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Model
            {
                MachineName = Environment.MachineName,
                IPs = GetIPs(),
                AppPool = Request.ServerVariables["APP_POOL_ID"] ?? "Unknown"
            };

            return View(model);
        }

        private string GetIPs()
        {
            var hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            return string.Join(", ", hostEntry.AddressList
                               .Where(x => x.AddressFamily == AddressFamily.InterNetwork)
                               .Select(x => x.ToString())
            );
        }
    }
}

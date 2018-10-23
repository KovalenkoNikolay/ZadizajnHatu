using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestEase;
using Web.ApiContracts;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
           IUserApi api = RestClient.For<IUserApi>("http://localhost:51662");

            await api.RegisterClientAsync(new Contracts.User {
                Email = "email2@email.com",
                UserName = "email2@email.com",
                FirstName = "FirstName",
            });

            await api.LoginAsync();

            var isAuthorized = User.Identity.IsAuthenticated;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

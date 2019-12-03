using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityWebApp.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityWebApp.Controllers
{
    public class HomeController : Controller
    {

        private UserManager<AppUser> UserManager;
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await UserManager.FindByEmailAsync(User.Identity.Name);
                if (await UserManager.IsInRoleAsync(user, "Informático"))
                {
                    return View();
                }

                else
                {

                    return RedirectToAction("Index");
                }
            }
            return NotFound();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

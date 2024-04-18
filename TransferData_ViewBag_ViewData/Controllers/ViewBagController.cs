using Microsoft.AspNetCore.Mvc;
using TransferData_ViewBag_ViewData.Models;

namespace TransferData_ViewBag_ViewData.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "TehranIT.Net";
            ViewBag.Time= DateTime.Now;
            ViewBag.User = new Users
            {
                UserId = 1,
                UserName = "Mohammadreza",
                UserFamily = "ahadian"
            };
            return View();
        }
    }
}

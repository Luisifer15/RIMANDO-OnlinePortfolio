using Microsoft.AspNetCore.Mvc;

namespace RIMANDO_OnlinePortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

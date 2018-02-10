using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    public class MgrController : Controller
    {
        /// <summary>
        /// 框架首页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
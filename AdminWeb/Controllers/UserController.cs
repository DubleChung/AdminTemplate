using Microsoft.AspNetCore.Mvc;

namespace AdminWeb.Controllers
{
    /// <summary>
    /// 用户信息控制器
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            if (Request.Method.ToLower().Equals("post"))
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public IActionResult LoginOut()
        {
            //清除登录的session信息

            return Redirect("Login");
        }
    }
}
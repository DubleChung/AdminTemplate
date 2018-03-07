using AdminWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <returns></returns>
        public IActionResult UserList()
        {
            return View();
        }

        /// <summary>
        /// 角色管理
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RoleList()
        {
            return View();
        }
        //Bind("offset,limit,order,sTime,eTime")
        [HttpPost]
        public IActionResult RoleList([FromBody]RequestBaseDto model)
        {
            var pageData = new PageDataDto<dynamic>();
            if (ModelState.IsValid)
            {
                try
                {
                    var pageSize = (model.limit + model.offset + 1);

                    for (int i = model.offset; i < pageSize; i++)
                    {
                        pageData.rows.Add(new
                        {
                            RoleID = i + 1,
                            RoleName = "测试角色名称_" + (i + 1).ToString(),
                            RowIndex = i + 1,
                            CreateTime = DateTime.Now
                        });
                    }

                    pageData.total = 100;
                }
                catch (Exception ex)
                {
                    //throw ex;
                }

            }

            return Json(pageData);
        }

        /// <summary>
        /// 角色菜单管理
        /// </summary>
        /// <returns></returns>
        public IActionResult RoleMenuList()
        {
            return View();
        }

        public IActionResult Action()
        {
            return View();
        }
    }
}
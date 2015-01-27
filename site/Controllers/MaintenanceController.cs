using Parse;
using site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace site.Controllers
{
    public class MaintenanceController : Controller
    {
        
        public ActionResult Maintenance()
        {
           //ParseClient.Initialize("OmIJRj0XHQrGQOkNZBWJHWXAAv9vpwlaE1a4X1SS", "3pTG20VbOeNaBwwYH52grMV9uyz9zq2b7sqnnoEw");
           //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            if (MyGlobalVariables.MyGlobalString == null)
            {
                return RedirectToAction("Login", "Account");
            }
           return View();
        }

     

    }
}

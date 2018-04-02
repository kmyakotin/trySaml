using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace TrySaml.Controllers
{
    [Authorize]
    public class SecureController : Controller
    {
        // GET: Secure
        public ActionResult Index()
        {
            var identity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;
            return View(identity?.Claims);
        }
    }
}
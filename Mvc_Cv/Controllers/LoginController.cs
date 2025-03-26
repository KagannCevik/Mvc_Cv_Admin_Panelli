using Mvc_Cv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc_Cv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLADMIN p)
        {
            Mvc5_Sıfırdan_Admin_CvEntities db = new Mvc5_Sıfırdan_Admin_CvEntities();
            var userinfo = db.TBLADMIN.FirstOrDefault(x => x.KULLANICIADI == p.KULLANICIADI && x.SIFRE == p.SIFRE);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.KULLANICIADI, false);
                Session["KULLANICIADI"]=userinfo.KULLANICIADI.ToString();
                return RedirectToAction("Index", "Deneyim");
            }
            else
            {
                return RedirectToAction("Index","Login");
            }
           
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
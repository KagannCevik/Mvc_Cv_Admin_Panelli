using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;

namespace Mvc_Cv.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TBLHOBILERIM> repo = new GenericRepository<TBLHOBILERIM>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]  
        public ActionResult Index(TBLHOBILERIM p )
        {
            var t = repo.Find(x=>x.ID == 1);
            t.ACIKLAMA1 = p.ACIKLAMA1;
            t.ACIKLAMA2 = p.ACIKLAMA2;
            repo.Tupdate(t);
            return RedirectToAction("Index");   
        }
    }
}
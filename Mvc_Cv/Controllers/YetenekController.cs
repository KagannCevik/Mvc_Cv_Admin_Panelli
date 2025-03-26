using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;
namespace Mvc_Cv.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        GenericRepository<TBLYETENEKLERIM> repo = new GenericRepository<TBLYETENEKLERIM>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(TBLYETENEKLERIM p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id )
        {
            var yetenek = repo.Find(x => x.ID == id);
            repo.Tdelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDuzenle(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(TBLYETENEKLERIM t)
        {
            var y = repo.Find(x => x.ID == t.ID);
            y.YETENEK = t.YETENEK;
            y.ORAN = t.ORAN;
            repo.Tupdate(y);
            return RedirectToAction("Index");
        }
    }
}
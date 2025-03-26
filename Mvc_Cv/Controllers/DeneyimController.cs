using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(TBLDENEYIMLERIM p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            TBLDENEYIMLERIM t=repo.Find(x=>x.ID==id);
            repo.Tdelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            TBLDENEYIMLERIM t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(TBLDENEYIMLERIM p)
        {
            TBLDENEYIMLERIM t = repo.Find(x => x.ID ==p.ID);
            t.BASLIK = p.BASLIK;
            t.ALTBASLIK = p.ALTBASLIK;
            t.ACIKLAMA = p.ACIKLAMA;
            t.TARIH = p.TARIH;
            repo.Tupdate(t);
            return RedirectToAction("Index");
        }
    }
}
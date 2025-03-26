using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;


namespace MvcCV_Projesi.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TBLSERTIFIKALARIM> repo = new GenericRepository<TBLSERTIFIKALARIM>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(TBLSERTIFIKALARIM t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.ACIKLAMA = t.ACIKLAMA;
            sertifika.TARIH = t.TARIH;
            repo.Tupdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(TBLSERTIFIKALARIM p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            repo.Tdelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}
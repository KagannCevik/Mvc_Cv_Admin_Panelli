using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;

namespace Mvc_Cv.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<TBLSOSYALMEDYA> repo = new GenericRepository<TBLSOSYALMEDYA>();
        
        public ActionResult Index()
        {
            var SosyalMedya = repo.List();
            return View(SosyalMedya);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(TBLSOSYALMEDYA p)
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap = repo.Find(x=>x.ID==id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(TBLSOSYALMEDYA p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.AD = p.AD;
            hesap.LINK = p.LINK;
            hesap.IKON=p.IKON;
            repo.Tupdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var hesap =repo.Find(x=>x.ID==id);
            hesap.DURUM = false;
            repo.Tupdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Aktif(int id)
        {
            var hesap = repo.Find(x => x.ID == id);
            hesap.DURUM = true;
            repo.Tupdate(hesap);
            return RedirectToAction("Index");
        }
    }
}
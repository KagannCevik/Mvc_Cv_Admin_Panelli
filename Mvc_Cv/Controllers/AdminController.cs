using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv.Controllers
{
    
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TBLADMIN> repo= new GenericRepository<TBLADMIN>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            TBLADMIN t = repo.Find(x => x.ID == id);
            return View(t);
           
        }
        [HttpPost]
        public ActionResult AdminDuzenle(TBLADMIN p)
        {
            var guncelle = repo.Find(x=>x.ID==p.ID);
            guncelle.KULLANICIADI = p.KULLANICIADI;
            guncelle.SIFRE = p.SIFRE;
            repo.Tupdate(guncelle);
            return RedirectToAction("Index");
        }
    
        public ActionResult AdminSil(int id)
        {
            TBLADMIN t = repo.Find(x=>x.ID== id);
            repo.Tdelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(TBLADMIN p )
        {
            repo.Tadd(p);
            return RedirectToAction("Index");
        }
      
    }
}
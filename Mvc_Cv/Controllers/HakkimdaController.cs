using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<TBLHAKKIMDA> repo = new GenericRepository<TBLHAKKIMDA> ();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TBLHAKKIMDA p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.AD = p.AD;
            t.SOYAD = p.SOYAD;
            t.ADRES = p.ADRES;
            t.TELOFON = p.TELOFON;
            t.MAIL = p.MAIL;
            t.ACIKLAMA = p.ACIKLAMA;    
            t.RESIM = p.RESIM;
            repo.Tupdate(t);
            return RedirectToAction("Index");
            
        }
    }
}
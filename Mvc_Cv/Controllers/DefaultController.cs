using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Mvc_Cv.Models.Entity;
namespace Mvc_Cv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        Mvc5_Sıfırdan_Admin_CvEntities db = new Mvc5_Sıfırdan_Admin_CvEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHAKKIMDA.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TBLDENEYIMLERIM.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitim = db.TBLEGITIM.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TBLYETENEKLERIM.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobi = db.TBLHOBILERIM.ToList();
            return PartialView(hobi);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifika = db.TBLSERTIFIKALARIM.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TBLILETISIM t)
        {
            t.TARIH = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
            return PartialView();
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TBLSOSYALMEDYA.Where(x => x.DURUM == true).ToList();
            return PartialView(sosyalmedya);
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv.Models.Entity;
using Mvc_Cv.Repositories;

namespace Mvc_Cv.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<TBLILETISIM> repo = new GenericRepository<TBLILETISIM>();
        public ActionResult Index()
        {
            var iletisim = repo.List();
            return View(iletisim);
        }
    }
}
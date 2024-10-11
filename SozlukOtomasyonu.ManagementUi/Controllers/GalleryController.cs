using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KutuphaneOtomasyonu.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager ifmm = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var files = ifmm.GetCagetoryList();
            return View(files);
        }
    }
}
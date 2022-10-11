using SonProje.Business.Services;
using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonProje.UIWeb.Controllers
{
    public class UrunController : Controller
    {
        UrunService service;
        // GET: Urun
        public ActionResult Index()
        {
            service = new UrunService();
            return View(service.HepsiniGetir());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Urun entity)
        {
            service = new UrunService();
            service.Ekle(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, Urun entity)
        {
            service = new UrunService();
            service.Guncelle(id, entity);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            service = new UrunService();
            service.Sil(id);
            return RedirectToAction("Index");
        }
    }
}
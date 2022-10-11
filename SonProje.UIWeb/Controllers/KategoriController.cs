using SonProje.Business.Services;
using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonProje.UIWeb.Controllers
{
    public class KategoriController : Controller
    {
        KategoriService service;
        // GET: Kategori
        public ActionResult Index()
        {
            service = new KategoriService();
            return View(service.HepsiniGetir());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kategori entity)
        {
            service = new KategoriService();
            service.Ekle(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id, Kategori entity)
        {
            service = new KategoriService();
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
            service = new KategoriService();
            service.Sil(id);
            return RedirectToAction("Index");
        }
    }
}
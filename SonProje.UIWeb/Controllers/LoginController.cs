using SonProje.Business.Services;
using SonProje.Data.Context;
using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonProje.UIWeb.Controllers
{
    public class LoginController : Controller
    {
        LoginService service;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                Login login = db.Login.Where(x => x.KullaniciAdi == entity.KullaniciAdi && x.Sifre == entity.Sifre).FirstOrDefault();
                if (login != null)
                {
                    return RedirectToAction("KullaniciListesi");                
                }
                else
                {
                    return Content("Hatalı Giriş");
                }
            }
        }

        public ActionResult KullaniciListesi()
        {
            service = new LoginService();
            return View(service.HepsiniGetir());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Login entity)
        {
            service = new LoginService();
            service.Ekle(entity);
            return RedirectToAction("KullaniciListesi");
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id,Login entity)
        {
            service = new LoginService();
            service.Guncelle(id,entity);
            return RedirectToAction("KullaniciListesi");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            service = new LoginService();
            service.Sil(id);
            return RedirectToAction("KullaniciListesi");
        }
    }
}
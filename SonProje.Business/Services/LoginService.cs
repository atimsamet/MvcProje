using SonProje.Business.Interface;
using SonProje.Data.Context;
using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SonProje.Business.Services
{
    public class LoginService : ILoginService
    {
        public void Ekle(Login entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Login.Add(entity);
                db.SaveChanges();
            }
        }

        public void Guncelle(int id, Login entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Login> HepsiniGetir()
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                List<Login> tumKullanicilar = db.Login.ToList();
                return tumKullanicilar;
            }
        }

        public void Sil(int id)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                var silinecekEleman = db.Login.Find(id);
                db.Login.Remove(silinecekEleman);
                db.SaveChanges();
            }
        }
    }
}

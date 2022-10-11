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
    public class UrunService : IUrunService
    {
        public void Ekle(Urun entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Urunler.Add(entity);
                db.SaveChanges();
            }
        }

        public void Guncelle(int id, Urun entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Urun> HepsiniGetir()
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                List<Urun> tumUrunler = db.Urunler.ToList();
                return tumUrunler;
            }
        }

        public void Sil(int id)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                var silinecekEleman = db.Urunler.Find(id);
                db.Urunler.Remove(silinecekEleman);
                db.SaveChanges();
            }
        }
    }
}

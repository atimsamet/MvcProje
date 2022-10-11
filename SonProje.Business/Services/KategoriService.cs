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
    public class KategoriService : IKategoriService
    {
        public void Ekle(Kategori entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Kategoriler.Add(entity);
                db.SaveChanges();
            }
        }

        public void Guncelle(int id, Kategori entity)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Kategori> HepsiniGetir()
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                List<Kategori> tumKategoriler = db.Kategoriler.ToList();
                return tumKategoriler;
            }
        }

        public void Sil(int id)
        {
            using (SonProjeDbContext db = new SonProjeDbContext())
            {
                var silinecekEleman = db.Kategoriler.Find(id);
                db.Kategoriler.Remove(silinecekEleman);
                db.SaveChanges();
            }
        }
    }
}

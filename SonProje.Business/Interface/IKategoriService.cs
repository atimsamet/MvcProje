using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProje.Business.Interface
{
    public interface IKategoriService
    {
        List<Kategori> HepsiniGetir();
        void Ekle(Kategori entity);
        void Sil(int id);
        void Guncelle(int id, Kategori entity);
    }
}

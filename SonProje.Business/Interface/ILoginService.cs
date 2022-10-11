using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProje.Business.Interface
{
    public interface ILoginService
    {
        List<Login> HepsiniGetir();
        void Ekle(Login entity);
        void Guncelle(int id, Login entity);
        void Sil(int id);

    }
}

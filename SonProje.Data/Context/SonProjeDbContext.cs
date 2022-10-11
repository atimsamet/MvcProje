using SonProje.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProje.Data.Context
{
    public class SonProjeDbContext : DbContext
    {
        public SonProjeDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=SonProje;uid=sa;pwd=1234;";
            //Database.Connection.ConnectionString = "server=;database=;Trusted_Connection=True";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Urun> Urunler{ get; set; }
        public DbSet<Kategori> Kategoriler{ get; set; }
        public DbSet<Login> Login{ get; set; }


    }
}

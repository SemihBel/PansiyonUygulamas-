using Pansiyon_UI.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Pansiyon_UI.DataAccessLayer


{
    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Konaklamalar> Konaklamalar { get; set; }
        public virtual DbSet<Müsteriler> Musteriler { get; set; }
        public virtual DbSet<Odalar> Odalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Müsteriler>()
            //    .HasMany(e => e.Konaklamalar)
            //    .WithRequired(e => e.Müsteriler)
            //    .HasForeignKey(e => e.MusteriID);

            //modelBuilder.Entity<Odalar>()
            //    .HasMany(e => e.Konaklamalar)
            //    .WithRequired(e => e.Odalar)
            //    .HasForeignKey(e => e.OdaID);
        }
    }
}

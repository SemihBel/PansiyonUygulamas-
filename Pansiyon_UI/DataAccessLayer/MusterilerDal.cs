using Pansiyon_UI.BusinessLayer;
using Pansiyon_UI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_UI.DataAccessLayer
{
   public class MusterilerDal
    {
        public void Ekle(Müsteriler musteri)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Entry(musteri);
                result.State = EntityState.Added;
                context.SaveChanges();
            }
        }

       
        public void Guncelle(Müsteriler musteri)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Entry(musteri);
                result.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Sil(Müsteriler musteri)
        {
            using (MyContext context = new MyContext())
            {
                var result = context.Entry(musteri);
                result.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Entities.Müsteriler> Listele()
        {
            MyContext context = new MyContext();
            
                return context.Musteriler.ToList();
            
        }
    }
}

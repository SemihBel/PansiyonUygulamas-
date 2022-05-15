using Pansiyon_UI.DataAccessLayer;
using Pansiyon_UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_UI.BusinessLayer
{
    public class MusteriManager
    {
        MusterilerDal musterilerDal = new MusterilerDal();

        public void Ekle(Müsteriler musteri)
        {
            musterilerDal.Ekle(musteri);
        }
        public void Guncelle(Müsteriler musteri)
        {
            musterilerDal.Guncelle(musteri);
        }
        public void Sil(Müsteriler musteri)
        {
            musterilerDal.Sil(musteri);

        }

        public List<Müsteriler> Listele()
        {
            return musterilerDal.Listele();
        }
    }
}

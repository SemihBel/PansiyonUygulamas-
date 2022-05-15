using Pansiyon_UI.DataAccessLayer;
using Pansiyon_UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_UI.BusinessLayer
{
    class OdalarManager
    {
        OdalarDal odalarDal = new OdalarDal();

        public void OdaGuncelleKonaklamaGiris(Odalar oda)
        {
            oda.MusaitMi = false;
            Guncelle(oda);
        }
        public void OdaGuncelleKonaklamaCikis(Odalar oda)
        {
            oda.MusaitMi = true;
            Guncelle(oda);
        }

        public void Ekle(Odalar oda)
        {
            odalarDal.Ekle(oda);
        }
        public void Guncelle(Odalar oda)
        {
            odalarDal.Guncelle(oda);
        }
        public void Sil(Odalar oda)
        {
            odalarDal.Sil(oda);

        }

        public List<Odalar> Listele()
        {
            return odalarDal.Listele();
        }

        public Odalar GetOda(int id)
        {
            return odalarDal.GetOda(id);
        }
    }
}

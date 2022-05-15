using Pansiyon_UI.DataAccessLayer;
using Pansiyon_UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_UI.BusinessLayer
{
    public class KonaklamaManager
    {
        KonaklamalarDal konaklamalarDal = new KonaklamalarDal();

        public void Ekle(Konaklamalar konaklama)
        {
            konaklamalarDal.Ekle(konaklama);
        }

        public void Guncelle(Konaklamalar konaklama)
        {
            konaklamalarDal.Guncelle(konaklama);
        }

        public void Sil(Konaklamalar konaklama)
        {
            konaklamalarDal.Sil(konaklama);
        }

        public List<Konaklamalar> Listele()
        {
            return konaklamalarDal.Listele();
        }

        public Konaklamalar GetKonaklama(int id)
        {
            return konaklamalarDal.GetKonaklama(id);
        }
    }
}

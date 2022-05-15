using Pansiyon_UI.BusinessLayer;
using Pansiyon_UI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_UI.UI_Formlar
{
    public partial class KonaklamalarForm : Form
    {
        public int Musteriid { get; set; }
        public string  MusteriAdiSoyadi { get; set; }

        public KonaklamalarForm()
        {
            InitializeComponent();
        }
        KonaklamaManager konaklamaManager = new KonaklamaManager();
       

    
        private void KonaklamaListele()
        {
            dataGridView1.DataSource = konaklamaManager.Listele().Where
                (k => k.AktifMi == true &&k.MusteriID==Musteriid).ToList();
        }

        private void KonaklamalarForm_Load(object sender, EventArgs e)
        {
            tbxMusAdi.Text = MusteriAdiSoyadi;
            GunSayisiHesapla();
            KonaklamaListele();
            OdaSec();
        }
        private void GunSayisiHesapla()
        {
            TimeSpan gunSayisi;
            gunSayisi = DateTime.Parse(dtpCikis.Text) - DateTime.Parse(dtpGırıs.Text);
            tbxGunsayi.Text = gunSayisi.TotalDays.ToString();
        }

        private void dtpGırıs_ValueChanged(object sender, EventArgs e)
        {
            GunSayisiHesapla();
            ToplamFiyatHesapla();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            GunSayisiHesapla();
            ToplamFiyatHesapla();
        }

        private void OdaSec()
        {
            OdalarManager odalarManager = new OdalarManager();

            int x = 50;
            int y = 50;
            int sutun = 1;
            for (int i = 0; i < odalarManager.Listele().Count; i++)
            {
                Button button = new Button();
                button.Location = new Point(x, y);

                button.Height = 50;
                button.Width = 50;
                button.Text = odalarManager.Listele()[i].OdaNo.ToString();
                button.Name = odalarManager.Listele()[i].ID.ToString();

                button.Click += new EventHandler(SeciliButon);

                grbOdalar.Controls.Add(button);
                if (!odalarManager.Listele()[i].MusaitMi)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
                else
                {
                    button.BackColor = Color.Green;
                }
                if (sutun<5)
                {
                    x += 80;
                    sutun++;
                }
                else
                {
                    sutun = 1;
                    x = 50;
                    y += 80;
                }

            }
            
                       
        }
        private void SeciliButon(object sender, EventArgs eventArgs)
        {
            Button dinamikButon = (sender as Button);
            tbxOdaNu.Text = dinamikButon.Text;
            tbxOdaıd.Text = dinamikButon.Name;
            OdalarManager odalarManager = new OdalarManager();
            int id = Convert.ToInt32(tbxOdaıd.Text);
            Odalar oda = odalarManager.GetOda(id);
            tbxOdaFiyatı.Text = oda.Fiyat.ToString();
            ToplamFiyatHesapla();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbxOdaıd.Text!="" && tbxToplamfiyat.Text!="" &&
                cbxKonaklamadurum.Checked)
            {
                Konaklamalar konaklama = new Konaklamalar()
                {
                    MusteriID = Musteriid,
                    OdaID = Convert.ToInt32(tbxOdaıd.Text),                    
                    GirisTarihi = dtpGırıs.Value,
                    CikisTarihi = dtpCikis.Value,
                    AktifMi = cbxKonaklamadurum.Checked,
                    ToplamFiyat = Convert.ToDecimal(tbxToplamfiyat.Text),
                    
                };
                konaklamaManager.Ekle(konaklama);
                OdalarManager odalarManager = new OdalarManager();
                Odalar oda = new Odalar();
                oda = odalarManager.Listele().Where
                    (o => o.OdaNo == tbxOdaNu.Text).FirstOrDefault();

                odalarManager.OdaGuncelleKonaklamaGiris(oda);

                KonaklamaListele();
                grbOdalar.Controls.Clear();
                OdaSec();

               
            }
            else
            {
                MessageBox.Show("Lütfen önce bir oda seçin ve boş alanları doldurun " +
                    " (TARİH,FİYAT,KONAKLAMA DURUMU)");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ( tbxOdaıd.Text != "" && tbxToplamfiyat.Text != "" &&
                tbxKonaklmaID.Text!="")
            {
                Konaklamalar konaklama = new Konaklamalar()
                {
                    ID = Convert.ToInt32(tbxKonaklmaID.Text),
                    MusteriID = Musteriid,
                    OdaID = Convert.ToInt32(tbxOdaıd.Text),
                    GirisTarihi = dtpGırıs.Value,
                    CikisTarihi = dtpCikis.Value,
                    AktifMi = cbxKonaklamadurum.Checked,
                    ToplamFiyat = Convert.ToDecimal(tbxToplamfiyat.Text)
                };
                konaklamaManager.Guncelle(konaklama);

                if (!konaklama.AktifMi)
                {
                    OdalarManager odalarManager = new OdalarManager();
                    Odalar oda = new Odalar();
                    oda = odalarManager.Listele().Where(o => o.ID ==
                    Convert.ToInt32(tbxOdaıd.Text)).FirstOrDefault();
                    odalarManager.OdaGuncelleKonaklamaCikis(oda);

                }
                KonaklamaListele();
                grbOdalar.Controls.Clear();
                OdaSec();
            }
            else
            {
                MessageBox.Show("Lütfen bir kayıt seçin");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxKonaklmaID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxOdaıd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpGırıs.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            dtpCikis.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            tbxToplamfiyat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbxKonaklamadurum.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[6].Value);

        }



        private void ToplamFiyatHesapla()
        {
            tbxToplamfiyat.Text=(Convert.ToDecimal(tbxOdaFiyatı.Text)*
                Convert.ToInt32(tbxGunsayi.Text)).ToString();
        }

    }
}

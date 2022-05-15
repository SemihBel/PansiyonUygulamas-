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
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }

       MusteriManager musteriManager=new  MusteriManager();

        private void Musteriler_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        public void MusteriListele()
        {
            dataGridView1.DataSource = musteriManager.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Müsteriler musteriler = new Müsteriler()
            {
                Isim = tbxIsim.Text,
                Soyisim = tbxIsim.Text,
                Telefon = mtbxTelefon.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.Text,
                TCNo = tbxTC.Text,
            };
            musteriManager.Ekle(musteriler);
            MusteriListele();
            TextBoxTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Müsteriler musteri = new Müsteriler()
            {
                ID = Convert.ToInt32(tbxID.Text),
                Isim = tbxIsim.Text,
                Soyisim = tbxSoyisim.Text,
                TCNo = tbxTC.Text,
                Telefon = mtbxTelefon.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.Text
            };
            musteriManager.Guncelle(musteri);
            MusteriListele();
            TextBoxTemizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Müsteriler musteri = new Müsteriler()
            {
                ID =Convert.ToInt32(tbxID.Text),
                Isim=tbxIsim.Text,
                Soyisim=tbxSoyisim.Text,
                TCNo=tbxTC.Text,
                Telefon=mtbxTelefon.Text,
                Email=tbxEmail.Text,
                Cinsiyet=cbxCinsiyet.Text
            };
            musteriManager.Sil(musteri);
            MusteriListele();
            TextBoxTemizle();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxIsim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxSoyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtbxTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            cbxCinsiyet.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxTC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void TextBoxTemizle()
        {
            tbxID.Clear();
            tbxIsim.Clear();
            tbxSoyisim.Clear();
            tbxTC.Clear();
            tbxEmail.Clear();
            mtbxTelefon.Clear();
            cbxCinsiyet.SelectedItem = null;
        }

        private void btnKonaklamaEkle_Click(object sender, EventArgs e)
        {
            KonaklamalarForm konaklamalarForm = new KonaklamalarForm();

            konaklamalarForm.Musteriid = Convert.ToInt32(tbxID.Text);
            konaklamalarForm.MusteriAdiSoyadi = tbxIsim.Text  +  tbxSoyisim.Text;

            konaklamalarForm.ShowDialog();
        }

        
    }
}

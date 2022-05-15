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
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }

        OdalarManager odaManager = new OdalarManager();
        private void OdalarForm_Load(object sender, EventArgs e)
        {
            OdaListele();
        }
        public void OdaListele()
        {
            dataGridView1.DataSource = odaManager.Listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxOdaNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbxMusaitmi.Checked =Convert.ToBoolean( dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar()
            {
                
                OdaNo = tbxOdaNo.Text,
                Fiyat =Convert.ToDecimal(tbxFiyat.Text),
                MusaitMi = cbxMusaitmi.Checked,
             
            };
            odaManager.Ekle(odalar);
            OdaListele();
            TextBoxTemizle();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar()
            {
                ID = Convert.ToInt32(tbxID.Text),
                OdaNo = tbxOdaNo.Text,
                Fiyat = Convert.ToDecimal(tbxFiyat.Text),
                MusaitMi = cbxMusaitmi.Checked,
               
            };
            odaManager.Sil(oda);
            OdaListele();
            TextBoxTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Odalar oda = new Odalar()
            {
                ID = Convert.ToInt32(tbxID.Text),
                OdaNo = tbxOdaNo.Text,
                Fiyat = Convert.ToDecimal(tbxFiyat.Text),
                MusaitMi = cbxMusaitmi.Checked,

            };
            odaManager.Guncelle(oda);
            OdaListele();
            TextBoxTemizle();
        }
        private void TextBoxTemizle()
        {
            tbxID.Clear();
            tbxOdaNo.Clear();
            tbxFiyat.Clear();
            cbxMusaitmi.Checked = false;
         
        }
    }
}

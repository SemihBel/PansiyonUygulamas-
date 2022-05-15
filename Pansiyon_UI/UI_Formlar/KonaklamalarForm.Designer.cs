
namespace Pansiyon_UI.UI_Formlar
{
    partial class KonaklamalarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKonaklamalarId = new System.Windows.Forms.Label();
            this.lblMsteriAdi = new System.Windows.Forms.Label();
            this.lblNO = new System.Windows.Forms.Label();
            this.lblGırıs = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.Gunsayisi = new System.Windows.Forms.Label();
            this.lblOdaId = new System.Windows.Forms.Label();
            this.lblToplamFiayt = new System.Windows.Forms.Label();
            this.lblKonaklamaDurum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpGırıs = new System.Windows.Forms.DateTimePicker();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.cbxKonaklamadurum = new System.Windows.Forms.CheckBox();
            this.tbxKonaklmaID = new System.Windows.Forms.TextBox();
            this.tbxOdaıd = new System.Windows.Forms.TextBox();
            this.tbxOdaNu = new System.Windows.Forms.TextBox();
            this.tbxMusAdi = new System.Windows.Forms.TextBox();
            this.tbxGunsayi = new System.Windows.Forms.TextBox();
            this.tbxToplamfiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grbOdalar = new System.Windows.Forms.GroupBox();
            this.lblOdaFiyatı = new System.Windows.Forms.Label();
            this.tbxOdaFiyatı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKonaklamalarId
            // 
            this.lblKonaklamalarId.AutoSize = true;
            this.lblKonaklamalarId.Location = new System.Drawing.Point(53, 38);
            this.lblKonaklamalarId.Name = "lblKonaklamalarId";
            this.lblKonaklamalarId.Size = new System.Drawing.Size(109, 17);
            this.lblKonaklamalarId.TabIndex = 0;
            this.lblKonaklamalarId.Text = "Konaklamalar Id";
            // 
            // lblMsteriAdi
            // 
            this.lblMsteriAdi.AutoSize = true;
            this.lblMsteriAdi.Location = new System.Drawing.Point(53, 70);
            this.lblMsteriAdi.Name = "lblMsteriAdi";
            this.lblMsteriAdi.Size = new System.Drawing.Size(78, 17);
            this.lblMsteriAdi.TabIndex = 1;
            this.lblMsteriAdi.Text = "Müşteri Adi";
            // 
            // lblNO
            // 
            this.lblNO.AutoSize = true;
            this.lblNO.Location = new System.Drawing.Point(53, 105);
            this.lblNO.Name = "lblNO";
            this.lblNO.Size = new System.Drawing.Size(57, 17);
            this.lblNO.TabIndex = 2;
            this.lblNO.Text = "Oda No";
            // 
            // lblGırıs
            // 
            this.lblGırıs.AutoSize = true;
            this.lblGırıs.Location = new System.Drawing.Point(53, 140);
            this.lblGırıs.Name = "lblGırıs";
            this.lblGırıs.Size = new System.Drawing.Size(72, 17);
            this.lblGırıs.TabIndex = 3;
            this.lblGırıs.Text = "Giris tarihi";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Location = new System.Drawing.Point(53, 178);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(77, 17);
            this.lblCikis.TabIndex = 4;
            this.lblCikis.Text = "Cıkıs Tarihi";
            // 
            // Gunsayisi
            // 
            this.Gunsayisi.AutoSize = true;
            this.Gunsayisi.Location = new System.Drawing.Point(53, 222);
            this.Gunsayisi.Name = "Gunsayisi";
            this.Gunsayisi.Size = new System.Drawing.Size(76, 17);
            this.Gunsayisi.TabIndex = 5;
            this.Gunsayisi.Text = "Gün Sayisi";
            // 
            // lblOdaId
            // 
            this.lblOdaId.AutoSize = true;
            this.lblOdaId.Location = new System.Drawing.Point(251, 105);
            this.lblOdaId.Name = "lblOdaId";
            this.lblOdaId.Size = new System.Drawing.Size(52, 17);
            this.lblOdaId.TabIndex = 6;
            this.lblOdaId.Text = "Oda ID";
            // 
            // lblToplamFiayt
            // 
            this.lblToplamFiayt.AutoSize = true;
            this.lblToplamFiayt.Location = new System.Drawing.Point(53, 279);
            this.lblToplamFiayt.Name = "lblToplamFiayt";
            this.lblToplamFiayt.Size = new System.Drawing.Size(89, 17);
            this.lblToplamFiayt.TabIndex = 7;
            this.lblToplamFiayt.Text = "Toplam Fiyat";
            // 
            // lblKonaklamaDurum
            // 
            this.lblKonaklamaDurum.AutoSize = true;
            this.lblKonaklamaDurum.Location = new System.Drawing.Point(53, 319);
            this.lblKonaklamaDurum.Name = "lblKonaklamaDurum";
            this.lblKonaklamaDurum.Size = new System.Drawing.Size(132, 17);
            this.lblKonaklamaDurum.TabIndex = 8;
            this.lblKonaklamaDurum.Text = "Konaklama Durumu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(784, 189);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dtpGırıs
            // 
            this.dtpGırıs.Location = new System.Drawing.Point(190, 140);
            this.dtpGırıs.Name = "dtpGırıs";
            this.dtpGırıs.Size = new System.Drawing.Size(200, 22);
            this.dtpGırıs.TabIndex = 10;
            this.dtpGırıs.ValueChanged += new System.EventHandler(this.dtpGırıs_ValueChanged);
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(190, 178);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(200, 22);
            this.dtpCikis.TabIndex = 11;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // cbxKonaklamadurum
            // 
            this.cbxKonaklamadurum.AutoSize = true;
            this.cbxKonaklamadurum.Location = new System.Drawing.Point(222, 315);
            this.cbxKonaklamadurum.Name = "cbxKonaklamadurum";
            this.cbxKonaklamadurum.Size = new System.Drawing.Size(34, 21);
            this.cbxKonaklamadurum.TabIndex = 12;
            this.cbxKonaklamadurum.Text = " ";
            this.cbxKonaklamadurum.UseVisualStyleBackColor = true;
            // 
            // tbxKonaklmaID
            // 
            this.tbxKonaklmaID.Location = new System.Drawing.Point(206, 38);
            this.tbxKonaklmaID.Name = "tbxKonaklmaID";
            this.tbxKonaklmaID.Size = new System.Drawing.Size(100, 22);
            this.tbxKonaklmaID.TabIndex = 13;
            // 
            // tbxOdaıd
            // 
            this.tbxOdaıd.Location = new System.Drawing.Point(325, 105);
            this.tbxOdaıd.Name = "tbxOdaıd";
            this.tbxOdaıd.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaıd.TabIndex = 14;
            // 
            // tbxOdaNu
            // 
            this.tbxOdaNu.Location = new System.Drawing.Point(132, 105);
            this.tbxOdaNu.Name = "tbxOdaNu";
            this.tbxOdaNu.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaNu.TabIndex = 15;
            // 
            // tbxMusAdi
            // 
            this.tbxMusAdi.Location = new System.Drawing.Point(206, 70);
            this.tbxMusAdi.Name = "tbxMusAdi";
            this.tbxMusAdi.Size = new System.Drawing.Size(100, 22);
            this.tbxMusAdi.TabIndex = 16;
            // 
            // tbxGunsayi
            // 
            this.tbxGunsayi.Location = new System.Drawing.Point(206, 217);
            this.tbxGunsayi.Name = "tbxGunsayi";
            this.tbxGunsayi.Size = new System.Drawing.Size(100, 22);
            this.tbxGunsayi.TabIndex = 17;
            // 
            // tbxToplamfiyat
            // 
            this.tbxToplamfiyat.Location = new System.Drawing.Point(206, 279);
            this.tbxToplamfiyat.Name = "tbxToplamfiyat";
            this.tbxToplamfiyat.Size = new System.Drawing.Size(100, 22);
            this.tbxToplamfiyat.TabIndex = 18;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(58, 406);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(181, 406);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "GUNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // grbOdalar
            // 
            this.grbOdalar.Location = new System.Drawing.Point(446, 27);
            this.grbOdalar.Name = "grbOdalar";
            this.grbOdalar.Size = new System.Drawing.Size(465, 331);
            this.grbOdalar.TabIndex = 21;
            this.grbOdalar.TabStop = false;
            this.grbOdalar.Text = "Odalar";
          
            // 
            // lblOdaFiyatı
            // 
            this.lblOdaFiyatı.AutoSize = true;
            this.lblOdaFiyatı.Location = new System.Drawing.Point(64, 251);
            this.lblOdaFiyatı.Name = "lblOdaFiyatı";
            this.lblOdaFiyatı.Size = new System.Drawing.Size(68, 17);
            this.lblOdaFiyatı.TabIndex = 22;
            this.lblOdaFiyatı.Text = "OdaFiyatı";
            // 
            // tbxOdaFiyatı
            // 
            this.tbxOdaFiyatı.Location = new System.Drawing.Point(206, 248);
            this.tbxOdaFiyatı.Name = "tbxOdaFiyatı";
            this.tbxOdaFiyatı.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaFiyatı.TabIndex = 23;
            // 
            // KonaklamalarForm
            // 
            this.ClientSize = new System.Drawing.Size(1104, 578);
            this.Controls.Add(this.tbxOdaFiyatı);
            this.Controls.Add(this.lblOdaFiyatı);
            this.Controls.Add(this.grbOdalar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxToplamfiyat);
            this.Controls.Add(this.tbxGunsayi);
            this.Controls.Add(this.tbxMusAdi);
            this.Controls.Add(this.tbxOdaNu);
            this.Controls.Add(this.tbxOdaıd);
            this.Controls.Add(this.tbxKonaklmaID);
            this.Controls.Add(this.cbxKonaklamadurum);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGırıs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKonaklamaDurum);
            this.Controls.Add(this.lblToplamFiayt);
            this.Controls.Add(this.lblOdaId);
            this.Controls.Add(this.Gunsayisi);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGırıs);
            this.Controls.Add(this.lblNO);
            this.Controls.Add(this.lblMsteriAdi);
            this.Controls.Add(this.lblKonaklamalarId);
            this.Name = "KonaklamalarForm";
            this.Load += new System.EventHandler(this.KonaklamalarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKonaklamalarId;
        private System.Windows.Forms.Label lblMsteriAdi;
        private System.Windows.Forms.Label lblNO;
        private System.Windows.Forms.Label lblGırıs;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label Gunsayisi;
        private System.Windows.Forms.Label lblOdaId;
        private System.Windows.Forms.Label lblToplamFiayt;
        private System.Windows.Forms.Label lblKonaklamaDurum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpGırıs;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.CheckBox cbxKonaklamadurum;
        private System.Windows.Forms.TextBox tbxKonaklmaID;
        private System.Windows.Forms.TextBox tbxOdaıd;
        private System.Windows.Forms.TextBox tbxOdaNu;
        private System.Windows.Forms.TextBox tbxMusAdi;
        private System.Windows.Forms.TextBox tbxGunsayi;
        private System.Windows.Forms.TextBox tbxToplamfiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox grbOdalar;
        private System.Windows.Forms.Label lblOdaFiyatı;
        private System.Windows.Forms.TextBox tbxOdaFiyatı;
    }
}
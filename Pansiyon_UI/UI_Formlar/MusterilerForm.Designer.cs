
namespace Pansiyon_UI.UI_Formlar
{
    partial class MusterilerForm
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
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxIsim = new System.Windows.Forms.TextBox();
            this.tbxSoyisim = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.mtbxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTC = new System.Windows.Forms.Label();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.btnKonaklamaEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(49, 27);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(71, 17);
            this.lblMusteriID.TabIndex = 0;
            this.lblMusteriID.Text = "Müşteri ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(49, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(49, 160);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(49, 70);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(32, 17);
            this.lblIsim.TabIndex = 3;
            this.lblIsim.Text = "İsim";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(49, 118);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(56, 17);
            this.lblSoyisim.TabIndex = 4;
            this.lblSoyisim.Text = "Soyisim";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(116, 27);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 22);
            this.tbxID.TabIndex = 5;
            // 
            // tbxIsim
            // 
            this.tbxIsim.Location = new System.Drawing.Point(116, 70);
            this.tbxIsim.Name = "tbxIsim";
            this.tbxIsim.Size = new System.Drawing.Size(100, 22);
            this.tbxIsim.TabIndex = 6;
            // 
            // tbxSoyisim
            // 
            this.tbxSoyisim.Location = new System.Drawing.Point(116, 115);
            this.tbxSoyisim.Name = "tbxSoyisim";
            this.tbxSoyisim.Size = new System.Drawing.Size(100, 22);
            this.tbxSoyisim.TabIndex = 7;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(116, 195);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 22);
            this.tbxEmail.TabIndex = 9;
            // 
            // mtbxTelefon
            // 
            this.mtbxTelefon.Location = new System.Drawing.Point(116, 157);
            this.mtbxTelefon.Mask = "(999) 000-0000";
            this.mtbxTelefon.Name = "mtbxTelefon";
            this.mtbxTelefon.Size = new System.Drawing.Size(100, 22);
            this.mtbxTelefon.TabIndex = 10;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(34, 236);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(57, 17);
            this.lblCinsiyet.TabIndex = 11;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(116, 229);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(121, 24);
            this.cbxCinsiyet.TabIndex = 12;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(320, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 51);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(320, 82);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 41);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(320, 129);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 31);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 197);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(49, 277);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(26, 17);
            this.lblTC.TabIndex = 17;
            this.lblTC.Text = "TC";
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(116, 277);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(100, 22);
            this.tbxTC.TabIndex = 18;
            // 
            // btnKonaklamaEkle
            // 
            this.btnKonaklamaEkle.Location = new System.Drawing.Point(475, 25);
            this.btnKonaklamaEkle.Name = "btnKonaklamaEkle";
            this.btnKonaklamaEkle.Size = new System.Drawing.Size(107, 62);
            this.btnKonaklamaEkle.TabIndex = 19;
            this.btnKonaklamaEkle.Text = "KONAKLAMAEKLE";
            this.btnKonaklamaEkle.UseVisualStyleBackColor = true;
            this.btnKonaklamaEkle.Click += new System.EventHandler(this.btnKonaklamaEkle_Click);
            // 
            // MusterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 481);
            this.Controls.Add(this.btnKonaklamaEkle);
            this.Controls.Add(this.tbxTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.mtbxTelefon);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxSoyisim);
            this.Controls.Add(this.tbxIsim);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMusteriID);
            this.Name = "MusterilerForm";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxIsim;
        private System.Windows.Forms.TextBox tbxSoyisim;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.MaskedTextBox mtbxTelefon;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.Button btnKonaklamaEkle;
    }
}
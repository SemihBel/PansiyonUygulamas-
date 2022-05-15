
namespace Pansiyon_UI.UI_Formlar
{
    partial class OdalarForm
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
            this.OdaID = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblMusaitmi = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxOdaNo = new System.Windows.Forms.TextBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxMusaitmi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OdaID
            // 
            this.OdaID.AutoSize = true;
            this.OdaID.Location = new System.Drawing.Point(96, 33);
            this.OdaID.Name = "OdaID";
            this.OdaID.Size = new System.Drawing.Size(21, 17);
            this.OdaID.TabIndex = 0;
            this.OdaID.Text = "ID";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(96, 72);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(53, 17);
            this.lblOdaNo.TabIndex = 1;
            this.lblOdaNo.Text = "OdaNo";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(96, 106);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblMusaitmi
            // 
            this.lblMusaitmi.AutoSize = true;
            this.lblMusaitmi.Location = new System.Drawing.Point(96, 144);
            this.lblMusaitmi.Name = "lblMusaitmi";
            this.lblMusaitmi.Size = new System.Drawing.Size(67, 17);
            this.lblMusaitmi.TabIndex = 3;
            this.lblMusaitmi.Text = "Müsait Mİ";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(206, 33);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 22);
            this.tbxID.TabIndex = 4;
            // 
            // tbxOdaNo
            // 
            this.tbxOdaNo.Location = new System.Drawing.Point(206, 72);
            this.tbxOdaNo.Name = "tbxOdaNo";
            this.tbxOdaNo.Size = new System.Drawing.Size(100, 22);
            this.tbxOdaNo.TabIndex = 5;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(206, 106);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 22);
            this.tbxFiyat.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(358, 31);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(358, 84);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(358, 138);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 238);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cbxMusaitmi
            // 
            this.cbxMusaitmi.AutoSize = true;
            this.cbxMusaitmi.Location = new System.Drawing.Point(206, 139);
            this.cbxMusaitmi.Name = "cbxMusaitmi";
            this.cbxMusaitmi.Size = new System.Drawing.Size(18, 17);
            this.cbxMusaitmi.TabIndex = 12;
            this.cbxMusaitmi.UseVisualStyleBackColor = true;
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMusaitmi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxFiyat);
            this.Controls.Add(this.tbxOdaNo);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblMusaitmi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.OdaID);
            this.Name = "OdalarForm";
            this.Text = "OdalarForm";
            this.Load += new System.EventHandler(this.OdalarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OdaID;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblMusaitmi;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxOdaNo;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbxMusaitmi;
    }
}
namespace KisiselButceIstekIhtiyac.Views
{
    partial class FormZorunluGider
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiderAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGiderTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiderTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpGiderTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGiderEkle = new System.Windows.Forms.Button();
            this.btnGiderGuncelle = new System.Windows.Forms.Button();
            this.btnGiderSil = new System.Windows.Forms.Button();
            this.btnGiderTemizle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvGiderler = new System.Windows.Forms.DataGridView();
            this.lblToplamGider = new System.Windows.Forms.Label();
            this.btnAnaSayfaDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zorunlu Gider ve Sabit Harcama Yönetimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 70);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGiderTemizle);
            this.panel2.Controls.Add(this.btnGiderSil);
            this.panel2.Controls.Add(this.btnGiderGuncelle);
            this.panel2.Controls.Add(this.btnGiderEkle);
            this.panel2.Controls.Add(this.dtpGiderTarih);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtGiderTutar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbGiderTuru);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGiderAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 430);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gider Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gider Adı (Örn: Kira, Fatura)";
            // 
            // txtGiderAdi
            // 
            this.txtGiderAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiderAdi.Location = new System.Drawing.Point(20, 72);
            this.txtGiderAdi.Name = "txtGiderAdi";
            this.txtGiderAdi.Size = new System.Drawing.Size(265, 25);
            this.txtGiderAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gider Türü";
            // 
            // cmbGiderTuru
            // 
            this.cmbGiderTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGiderTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGiderTuru.FormattingEnabled = true;
            this.cmbGiderTuru.Items.AddRange(new object[] {
            "Kira / Konut",
            "Fatura (Elektrik/Su/İnternet)",
            "Market / Gıda",
            "Ulaşım / Yakıt",
            "Sağlık / Eğitim",
            "Diğer Zorunlu"});
            this.cmbGiderTuru.Location = new System.Drawing.Point(20, 128);
            this.cmbGiderTuru.Name = "cmbGiderTuru";
            this.cmbGiderTuru.Size = new System.Drawing.Size(265, 25);
            this.cmbGiderTuru.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tutar (TL)";
            // 
            // txtGiderTutar
            // 
            this.txtGiderTutar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiderTutar.Location = new System.Drawing.Point(20, 184);
            this.txtGiderTutar.Name = "txtGiderTutar";
            this.txtGiderTutar.Size = new System.Drawing.Size(265, 25);
            this.txtGiderTutar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Harcama Tarihi";
            // 
            // dtpGiderTarih
            // 
            this.dtpGiderTarih.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpGiderTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGiderTarih.Location = new System.Drawing.Point(20, 240);
            this.dtpGiderTarih.Name = "dtpGiderTarih";
            this.dtpGiderTarih.Size = new System.Drawing.Size(265, 25);
            this.dtpGiderTarih.TabIndex = 8;
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnGiderEkle.FlatAppearance.BorderSize = 0;
            this.btnGiderEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderEkle.ForeColor = System.Drawing.Color.White;
            this.btnGiderEkle.Location = new System.Drawing.Point(20, 285);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(265, 36);
            this.btnGiderEkle.TabIndex = 9;
            this.btnGiderEkle.Text = "Gider Ekle";
            this.btnGiderEkle.UseVisualStyleBackColor = false;
            // 
            // btnGiderGuncelle
            // 
            this.btnGiderGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.btnGiderGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGiderGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGiderGuncelle.Location = new System.Drawing.Point(20, 330);
            this.btnGiderGuncelle.Name = "btnGiderGuncelle";
            this.btnGiderGuncelle.Size = new System.Drawing.Size(128, 34);
            this.btnGiderGuncelle.TabIndex = 10;
            this.btnGiderGuncelle.Text = "Güncelle";
            this.btnGiderGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnGiderSil
            // 
            this.btnGiderSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnGiderSil.FlatAppearance.BorderSize = 0;
            this.btnGiderSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderSil.ForeColor = System.Drawing.Color.White;
            this.btnGiderSil.Location = new System.Drawing.Point(157, 330);
            this.btnGiderSil.Name = "btnGiderSil";
            this.btnGiderSil.Size = new System.Drawing.Size(128, 34);
            this.btnGiderSil.TabIndex = 11;
            this.btnGiderSil.Text = "Sil";
            this.btnGiderSil.UseVisualStyleBackColor = false;
            // 
            // btnGiderTemizle
            // 
            this.btnGiderTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
            this.btnGiderTemizle.FlatAppearance.BorderSize = 0;
            this.btnGiderTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnGiderTemizle.Location = new System.Drawing.Point(20, 373);
            this.btnGiderTemizle.Name = "btnGiderTemizle";
            this.btnGiderTemizle.Size = new System.Drawing.Size(265, 30);
            this.btnGiderTemizle.TabIndex = 12;
            this.btnGiderTemizle.Text = "Formu Temizle";
            this.btnGiderTemizle.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAnaSayfaDon);
            this.panel3.Controls.Add(this.lblToplamGider);
            this.panel3.Controls.Add(this.dgvGiderler);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(345, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 430);
            this.panel3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(15, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kayıtlı Zorunlu Giderler";
            // 
            // dgvGiderler
            // 
            this.dgvGiderler.AllowUserToAddRows = false;
            this.dgvGiderler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiderler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.dgvGiderler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiderler.Location = new System.Drawing.Point(15, 48);
            this.dgvGiderler.MultiSelect = false;
            this.dgvGiderler.Name = "dgvGiderler";
            this.dgvGiderler.ReadOnly = true;
            this.dgvGiderler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiderler.Size = new System.Drawing.Size(488, 320);
            this.dgvGiderler.TabIndex = 1;
            // 
            // lblToplamGider
            // 
            this.lblToplamGider.AutoSize = true;
            this.lblToplamGider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamGider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.lblToplamGider.Location = new System.Drawing.Point(15, 385);
            this.lblToplamGider.Name = "lblToplamGider";
            this.lblToplamGider.Size = new System.Drawing.Size(197, 17);
            this.lblToplamGider.TabIndex = 2;
            this.lblToplamGider.Text = "Toplam Zorunlu Gider: 0,00 TL";
            // 
            // btnAnaSayfaDon
            // 
            this.btnAnaSayfaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnAnaSayfaDon.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfaDon.ForeColor = System.Drawing.Color.White;
            this.btnAnaSayfaDon.Location = new System.Drawing.Point(383, 380);
            this.btnAnaSayfaDon.Name = "btnAnaSayfaDon";
            this.btnAnaSayfaDon.Size = new System.Drawing.Size(120, 32);
            this.btnAnaSayfaDon.TabIndex = 3;
            this.btnAnaSayfaDon.Text = "← Ana Sayfa";
            this.btnAnaSayfaDon.UseVisualStyleBackColor = false;
            // 
            // FormZorunluGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(884, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormZorunluGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zorunlu Gider Yönetimi";
            this.Load += new System.EventHandler(this.FormZorunluGider_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiderler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGiderTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiderAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiderTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGiderSil;
        private System.Windows.Forms.Button btnGiderGuncelle;
        private System.Windows.Forms.Button btnGiderEkle;
        private System.Windows.Forms.DateTimePicker dtpGiderTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiderTemizle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAnaSayfaDon;
        private System.Windows.Forms.Label lblToplamGider;
        private System.Windows.Forms.DataGridView dgvGiderler;
        private System.Windows.Forms.Label label7;
    }
}
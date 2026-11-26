namespace KisiselButceIstekIhtiyac.Views
{
    partial class FormAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminAnaSayfaDon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminMaas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminMesai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAdminRol = new System.Windows.Forms.ComboBox();
            this.btnAdminEkle = new System.Windows.Forms.Button();
            this.btnAdminGuncelle = new System.Windows.Forms.Button();
            this.btnAdminSil = new System.Windows.Forms.Button();
            this.btnAdminTemizle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToplamKullanici = new System.Windows.Forms.Label();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnAdminAnaSayfaDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici (Admin) Paneli — Kayıtlı Kullanıcı Yönetimi";
            // 
            // btnAdminAnaSayfaDon
            // 
            this.btnAdminAnaSayfaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(76)))), ((int)(((byte)(65)))));
            this.btnAdminAnaSayfaDon.FlatAppearance.BorderSize = 0;
            this.btnAdminAnaSayfaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAnaSayfaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminAnaSayfaDon.ForeColor = System.Drawing.Color.White;
            this.btnAdminAnaSayfaDon.Location = new System.Drawing.Point(835, 17);
            this.btnAdminAnaSayfaDon.Name = "btnAdminAnaSayfaDon";
            this.btnAdminAnaSayfaDon.Size = new System.Drawing.Size(150, 36);
            this.btnAdminAnaSayfaDon.TabIndex = 1;
            this.btnAdminAnaSayfaDon.Text = "← Ana Sayfaya Dön";
            this.btnAdminAnaSayfaDon.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAdminTemizle);
            this.panel2.Controls.Add(this.btnAdminSil);
            this.panel2.Controls.Add(this.btnAdminGuncelle);
            this.panel2.Controls.Add(this.btnAdminEkle);
            this.panel2.Controls.Add(this.cmbAdminRol);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAdminMesai);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAdminMaas);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAdminSifre);
            this.panel2.Controls.Add(this.txtAdminEmail);
            this.panel2.Controls.Add(this.txtAdminKullaniciAdi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(20, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 475);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // txtAdminKullaniciAdi
            // 
            this.txtAdminKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminKullaniciAdi.Location = new System.Drawing.Point(20, 66);
            this.txtAdminKullaniciAdi.Name = "txtAdminKullaniciAdi";
            this.txtAdminKullaniciAdi.Size = new System.Drawing.Size(270, 23);
            this.txtAdminKullaniciAdi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail Adresi";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminEmail.Location = new System.Drawing.Point(20, 116);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(270, 23);
            this.txtAdminEmail.TabIndex = 2;
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminSifre.Location = new System.Drawing.Point(20, 166);
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.Size = new System.Drawing.Size(270, 23);
            this.txtAdminSifre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(20, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şifre";
            // 
            // txtAdminMaas
            // 
            this.txtAdminMaas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminMaas.Location = new System.Drawing.Point(20, 216);
            this.txtAdminMaas.Name = "txtAdminMaas";
            this.txtAdminMaas.Size = new System.Drawing.Size(130, 23);
            this.txtAdminMaas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(20, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Aylık Maaş (TL)";
            // 
            // txtAdminMesai
            // 
            this.txtAdminMesai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdminMesai.Location = new System.Drawing.Point(160, 216);
            this.txtAdminMesai.Name = "txtAdminMesai";
            this.txtAdminMesai.Size = new System.Drawing.Size(130, 23);
            this.txtAdminMesai.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(160, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Günlük Mesai (Saat)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label8.Location = new System.Drawing.Point(20, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Yetki Rolü";
            // 
            // cmbAdminRol
            // 
            this.cmbAdminRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdminRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbAdminRol.FormattingEnabled = true;
            this.cmbAdminRol.Items.AddRange(new object[] {
            "Kullanici",
            "Admin"});
            this.cmbAdminRol.Location = new System.Drawing.Point(20, 266);
            this.cmbAdminRol.Name = "cmbAdminRol";
            this.cmbAdminRol.Size = new System.Drawing.Size(270, 23);
            this.cmbAdminRol.TabIndex = 4;
            // 
            // btnAdminEkle
            // 
            this.btnAdminEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdminEkle.FlatAppearance.BorderSize = 0;
            this.btnAdminEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminEkle.ForeColor = System.Drawing.Color.White;
            this.btnAdminEkle.Location = new System.Drawing.Point(20, 312);
            this.btnAdminEkle.Name = "btnAdminEkle";
            this.btnAdminEkle.Size = new System.Drawing.Size(270, 36);
            this.btnAdminEkle.TabIndex = 5;
            this.btnAdminEkle.Text = "Yeni Kullanıcı Ekle";
            this.btnAdminEkle.UseVisualStyleBackColor = false;
            // 
            // btnAdminGuncelle
            // 
            this.btnAdminGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.btnAdminGuncelle.FlatAppearance.BorderSize = 0;
            this.btnAdminGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnAdminGuncelle.Location = new System.Drawing.Point(20, 358);
            this.btnAdminGuncelle.Name = "btnAdminGuncelle";
            this.btnAdminGuncelle.Size = new System.Drawing.Size(130, 34);
            this.btnAdminGuncelle.TabIndex = 5;
            this.btnAdminGuncelle.Text = "Güncelle";
            this.btnAdminGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnAdminSil
            // 
            this.btnAdminSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnAdminSil.FlatAppearance.BorderSize = 0;
            this.btnAdminSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminSil.ForeColor = System.Drawing.Color.White;
            this.btnAdminSil.Location = new System.Drawing.Point(160, 358);
            this.btnAdminSil.Name = "btnAdminSil";
            this.btnAdminSil.Size = new System.Drawing.Size(130, 34);
            this.btnAdminSil.TabIndex = 5;
            this.btnAdminSil.Text = "Sil";
            this.btnAdminSil.UseVisualStyleBackColor = false;
            // 
            // btnAdminTemizle
            // 
            this.btnAdminTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(225)))), ((int)(((byte)(215)))));
            this.btnAdminTemizle.FlatAppearance.BorderSize = 0;
            this.btnAdminTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.btnAdminTemizle.Location = new System.Drawing.Point(20, 402);
            this.btnAdminTemizle.Name = "btnAdminTemizle";
            this.btnAdminTemizle.Size = new System.Drawing.Size(270, 32);
            this.btnAdminTemizle.TabIndex = 5;
            this.btnAdminTemizle.Text = "Formu Temizle";
            this.btnAdminTemizle.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvKullanicilar);
            this.panel3.Controls.Add(this.lblToplamKullanici);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(350, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 475);
            this.panel3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sistemdeki Tüm Kayıtlı Kullanıcılar";
            // 
            // lblToplamKullanici
            // 
            this.lblToplamKullanici.AutoSize = true;
            this.lblToplamKullanici.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(196)))));
            this.lblToplamKullanici.Location = new System.Drawing.Point(475, 17);
            this.lblToplamKullanici.Name = "lblToplamKullanici";
            this.lblToplamKullanici.Size = new System.Drawing.Size(109, 15);
            this.lblToplamKullanici.TabIndex = 1;
            this.lblToplamKullanici.Text = "Toplam Kullanıcı: 0";
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(16, 48);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(600, 405);
            this.dgvKullanicilar.TabIndex = 2;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1004, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici (Admin) Paneli — Kullanıcı Yönetimi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminAnaSayfaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdminMesai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.TextBox txtAdminKullaniciAdi;
        private System.Windows.Forms.Button btnAdminTemizle;
        private System.Windows.Forms.Button btnAdminSil;
        private System.Windows.Forms.Button btnAdminGuncelle;
        private System.Windows.Forms.Button btnAdminEkle;
        private System.Windows.Forms.ComboBox cmbAdminRol;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblToplamKullanici;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
    }
}
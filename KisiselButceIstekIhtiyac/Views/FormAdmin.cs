using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using KisiselButceIstekIhtiyac.Controllers;
using KisiselButceIstekIhtiyac.Models;

namespace KisiselButceIstekIhtiyac.Views
{
    public partial class FormAdmin : Form
    {
        private readonly AdminController adminController = new AdminController();
        private int seciliKullaniciId = 0;
        private bool formGecisiYapiliyor = false;

        public FormAdmin()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormAdmin_Load);
            this.FormClosed += new FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.btnAdminEkle.Click += new EventHandler(this.btnAdminEkle_Click);
            this.btnAdminGuncelle.Click += new EventHandler(this.btnAdminGuncelle_Click);
            this.btnAdminSil.Click += new EventHandler(this.btnAdminSil_Click);
            this.btnAdminTemizle.Click += new EventHandler(this.btnAdminTemizle_Click);
            this.btnAdminAnaSayfaDon.Click += new EventHandler(this.btnAdminAnaSayfaDon_Click);
            this.dgvKullanicilar.CellClick += new DataGridViewCellEventHandler(this.dgvKullanicilar_CellClick);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null || FormGiris.AktifKullanici.Rol != "Admin")
            {
                MessageBox.Show("Bu sayfaya yalnızca Admin yetkisine sahip kullanıcılar erişebilir.", "Yetkisiz Erişim", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                formGecisiYapiliyor = true;
                FormGiris giris = new FormGiris();
                giris.Show();
                this.Close();
                return;
            }

            btnAdminAnaSayfaDon.Cursor = Cursors.Hand;

            if (cmbAdminRol.Items.Count > 0)
                cmbAdminRol.SelectedIndex = 0;

            TabloStiliniUygula();
            ListeyiYenile();
        }

        private void TabloStiliniUygula()
        {
            dgvKullanicilar.EnableHeadersVisualStyles = false;
            dgvKullanicilar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 52, 46);
            dgvKullanicilar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKullanicilar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvKullanicilar.ColumnHeadersHeight = 32;
            dgvKullanicilar.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvKullanicilar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 225, 215);
            dgvKullanicilar.DefaultCellStyle.SelectionForeColor = Color.FromArgb(78, 52, 46);
            dgvKullanicilar.RowTemplate.Height = 28;
        }

        private void ListeyiYenile()
        {
            try
            {
                DataTable dt = adminController.TumKullanicilariGetir();
                dgvKullanicilar.DataSource = dt;

                if (dgvKullanicilar.Columns["KullaniciID"] != null)
                    dgvKullanicilar.Columns["KullaniciID"].Visible = false;

                lblToplamKullanici.Text = $"Toplam Kullanıcı: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            seciliKullaniciId = 0;
            txtAdminKullaniciAdi.Clear();
            txtAdminEmail.Clear();
            txtAdminSifre.Clear();
            txtAdminMaas.Clear();
            txtAdminMesai.Clear();
            if (cmbAdminRol.Items.Count > 0)
                cmbAdminRol.SelectedIndex = 0;
            dgvKullanicilar.ClearSelection();
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvKullanicilar.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow satir = dgvKullanicilar.Rows[e.RowIndex];

            if (satir.Cells["KullaniciID"].Value == null || satir.Cells["KullaniciID"].Value == DBNull.Value)
                return;

            string emailSutunu = dgvKullanicilar.Columns.Contains("E-Mail") ? "E-Mail" :
                                 (dgvKullanicilar.Columns.Contains("E-Posta") ? "E-Posta" : "Email");

            seciliKullaniciId = Convert.ToInt32(satir.Cells["KullaniciID"].Value);
            txtAdminKullaniciAdi.Text = satir.Cells["Kullanıcı Adı"].Value.ToString();
            txtAdminEmail.Text = satir.Cells[emailSutunu].Value.ToString();
            txtAdminSifre.Text = satir.Cells["Şifre"].Value.ToString();
            txtAdminMaas.Text = satir.Cells["Aylık Maaş (TL)"].Value.ToString();
            txtAdminMesai.Text = satir.Cells["Günlük Mesai (Saat)"].Value.ToString();

            string rol = satir.Cells["Rol"].Value.ToString();
            int rolIndex = cmbAdminRol.Items.IndexOf(rol);
            if (rolIndex >= 0) cmbAdminRol.SelectedIndex = rolIndex;
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdminKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtAdminEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAdminSifre.Text) ||
                string.IsNullOrWhiteSpace(txtAdminMaas.Text) ||
                string.IsNullOrWhiteSpace(txtAdminMesai.Text))
            {
                MessageBox.Show("Lütfen tüm kullanıcı bilgilerini eksiksiz doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAdminMaas.Text.Trim(), out decimal maas) || maas <= 0 ||
                !decimal.TryParse(txtAdminMesai.Text.Trim(), out decimal mesai) || mesai <= 0 || mesai > 24)
            {
                MessageBox.Show("Lütfen geçerli bir aylık maaş ve günlük çalışma saati (1-24) giriniz.", "Hatalı Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User yeniUser = new User
                {
                    KullaniciAdi = txtAdminKullaniciAdi.Text.Trim(),
                    Email = txtAdminEmail.Text.Trim(),
                    Sifre = txtAdminSifre.Text.Trim(),
                    AylikNetMaas = maas,
                    GunlukCalismaSaati = mesai,
                    Rol = cmbAdminRol.SelectedItem.ToString()
                };

                if (adminController.KullaniciEkle(yeniUser))
                {
                    MessageBox.Show("Yeni kullanıcı başarıyla sisteme eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullaniciId == 0)
            {
                MessageBox.Show("Lütfen önce tablodan güncellemek istediğiniz kullanıcıyı seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdminKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtAdminEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAdminSifre.Text) ||
                !decimal.TryParse(txtAdminMaas.Text.Trim(), out decimal maas) || maas <= 0 ||
                !decimal.TryParse(txtAdminMesai.Text.Trim(), out decimal mesai) || mesai <= 0 || mesai > 24)
            {
                MessageBox.Show("Lütfen geçerli kullanıcı bilgileri giriniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User guncelUser = new User
                {
                    KullaniciID = seciliKullaniciId,
                    KullaniciAdi = txtAdminKullaniciAdi.Text.Trim(),
                    Email = txtAdminEmail.Text.Trim(),
                    Sifre = txtAdminSifre.Text.Trim(),
                    AylikNetMaas = maas,
                    GunlukCalismaSaati = mesai,
                    Rol = cmbAdminRol.SelectedItem.ToString()
                };

                if (adminController.KullaniciGuncelle(guncelUser))
                {
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            if (seciliKullaniciId == 0)
            {
                MessageBox.Show("Lütfen tablodan silmek istediğiniz kullanıcıyı seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seciliKullaniciId == FormGiris.AktifKullanici.KullaniciID)
            {
                MessageBox.Show("Oturumu açık olan kendi yönetici hesabınızı silemezsiniz.", "İşlem Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Seçili kullanıcıyı ve bu kullanıcıya ait tüm finansal kayıtları silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (adminController.KullaniciSil(seciliKullaniciId))
                    {
                        MessageBox.Show("Kullanıcı kaydı sistemden silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AlanlariTemizle();
                        ListeyiYenile();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdminTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnAdminAnaSayfaDon_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!formGecisiYapiliyor)
            {
                Application.Exit();
            }
        }
    }
}
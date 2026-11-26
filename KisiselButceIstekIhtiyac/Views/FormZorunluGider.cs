using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KisiselButceIstekIhtiyac.Controllers;
using KisiselButceIstekIhtiyac.Models;

namespace KisiselButceIstekIhtiyac.Views
{
    public partial class FormZorunluGider : Form
    {
        private readonly GiderController giderController = new GiderController();
        private int seciliGiderId = 0;

        public FormZorunluGider()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormZorunluGider_Load);
            this.btnGiderEkle.Click += new EventHandler(this.btnGiderEkle_Click);
            this.btnGiderGuncelle.Click += new EventHandler(this.btnGiderGuncelle_Click);
            this.btnGiderSil.Click += new EventHandler(this.btnGiderSil_Click);
            this.btnGiderTemizle.Click += new EventHandler(this.btnGiderTemizle_Click);
            this.btnAnaSayfaDon.Click += new EventHandler(this.btnAnaSayfaDon_Click);
            this.dgvGiderler.CellClick += new DataGridViewCellEventHandler(this.dgvGiderler_CellClick);
        }

        private void FormZorunluGider_Load(object sender, EventArgs e)
        {
            if (cmbGiderTuru.Items.Count > 0)
                cmbGiderTuru.SelectedIndex = 0;

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            if (FormGiris.AktifKullanici == null) return;

            try
            {
                int kullaniciId = FormGiris.AktifKullanici.KullaniciID;
                dgvGiderler.DataSource = giderController.GiderleriGetir(kullaniciId);

                if (dgvGiderler.Columns["GiderID"] != null)
                    dgvGiderler.Columns["GiderID"].Visible = false;

                decimal toplam = giderController.ToplamGiderGetir(kullaniciId);
                lblToplamGider.Text = $"Toplam Zorunlu Gider: {toplam:N2} TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            seciliGiderId = 0;
            txtGiderAdi.Clear();
            txtGiderTutar.Clear();
            dtpGiderTarih.Value = DateTime.Now;
            if (cmbGiderTuru.Items.Count > 0)
                cmbGiderTuru.SelectedIndex = 0;
            dgvGiderler.ClearSelection();
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null) return;

            if (string.IsNullOrWhiteSpace(txtGiderAdi.Text) || string.IsNullOrWhiteSpace(txtGiderTutar.Text))
            {
                MessageBox.Show("Lütfen gider adı ve tutar alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtGiderTutar.Text.Trim(), out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Lütfen sıfırdan büyük geçerli bir tutar giriniz.", "Hatalı Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Gider yeniGider = new Gider
                {
                    KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                    GiderAdi = txtGiderAdi.Text.Trim(),
                    GiderTuru = cmbGiderTuru.SelectedItem.ToString(),
                    Tutar = tutar,
                    Tarih = dtpGiderTarih.Value
                };

                if (giderController.GiderEkle(yeniGider))
                {
                    MessageBox.Show("Zorunlu gider başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGiderler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvGiderler.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow satir = dgvGiderler.Rows[e.RowIndex];

            if (satir.Cells["GiderID"].Value == null || satir.Cells["GiderID"].Value == DBNull.Value)
                return;

            seciliGiderId = Convert.ToInt32(satir.Cells["GiderID"].Value);
            txtGiderAdi.Text = satir.Cells["Gider Adı"].Value.ToString();
            cmbGiderTuru.SelectedItem = satir.Cells["Gider Türü"].Value.ToString();
            txtGiderTutar.Text = satir.Cells["Tutar (TL)"].Value.ToString();
            dtpGiderTarih.Value = Convert.ToDateTime(satir.Cells["Tarih"].Value);
        }

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliGiderId == 0)
            {
                MessageBox.Show("Lütfen tablodan güncellemek istediğiniz gideri seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiderAdi.Text) || !decimal.TryParse(txtGiderTutar.Text.Trim(), out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir gider adı ve tutar giriniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Gider guncelGider = new Gider
                {
                    GiderID = seciliGiderId,
                    KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                    GiderAdi = txtGiderAdi.Text.Trim(),
                    GiderTuru = cmbGiderTuru.SelectedItem.ToString(),
                    Tutar = tutar,
                    Tarih = dtpGiderTarih.Value
                };

                if (giderController.GiderGuncelle(guncelGider))
                {
                    MessageBox.Show("Gider kaydı başarıyla güncellendi.", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiderSil_Click(object sender, EventArgs e)
        {
            if (seciliGiderId == 0)
            {
                MessageBox.Show("Lütfen tablodan silmek istediğiniz gideri seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Seçili gider kaydını kalıcı olarak silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (giderController.GiderSil(seciliGiderId, FormGiris.AktifKullanici.KullaniciID))
                    {
                        MessageBox.Show("Gider kaydı silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnGiderTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }
    }
}
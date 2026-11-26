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
    public partial class FormKarantina : Form
    {
        private readonly IstekController istekController = new IstekController();
        private Istek seciliIstek = null;

        public FormKarantina()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormKarantina_Load);
            this.cmbDurumFiltre.SelectedIndexChanged += new EventHandler(this.cmbDurumFiltre_SelectedIndexChanged);
            this.dgvKarantina.CellClick += new DataGridViewCellEventHandler(this.dgvKarantina_CellClick);
            this.btnYeniIstekAc.Click += new EventHandler(this.btnYeniIstekAc_Click);
            this.btnIstekGuncelleAc.Click += new EventHandler(this.btnIstekGuncelleAc_Click);
            this.btnVazgecildi.Click += new EventHandler(this.btnVazgecildi_Click);
            this.btnSatinAlindi.Click += new EventHandler(this.btnSatinAlindi_Click);
            this.btnIstekSil.Click += new EventHandler(this.btnIstekSil_Click);
            this.btnKarantinaGeriDon.Click += new EventHandler(this.btnKarantinaGeriDon_Click);
        }

        private void FormKarantina_Load(object sender, EventArgs e)
        {
            if (cmbDurumFiltre.Items.Count > 0)
                cmbDurumFiltre.SelectedIndex = 0;

            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            if (FormGiris.AktifKullanici == null) return;

            try
            {
                string seciliFiltre = cmbDurumFiltre.SelectedItem != null ? cmbDurumFiltre.SelectedItem.ToString() : "Tümü";
                dgvKarantina.DataSource = istekController.IstekleriGetir(FormGiris.AktifKullanici.KullaniciID, seciliFiltre);

                if (dgvKarantina.Columns["IstekID"] != null)
                    dgvKarantina.Columns["IstekID"].Visible = false;

                seciliIstek = null;
                lblSeciliIstekBilgi.Text = "Tablodan işlem yapmak istediğiniz isteği seçiniz.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDurumFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void dgvKarantina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvKarantina.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow satir = dgvKarantina.Rows[e.RowIndex];

            if (satir.Cells["IstekID"].Value == null || satir.Cells["IstekID"].Value == DBNull.Value)
                return;

            seciliIstek = new Istek
            {
                IstekID = Convert.ToInt32(satir.Cells["IstekID"].Value),
                KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                UrunAdi = satir.Cells["Ürün Adı"].Value.ToString(),
                Kategori = satir.Cells["Kategori"].Value.ToString(),
                Fiyat = Convert.ToDecimal(satir.Cells["Fiyat (TL)"].Value),
                Durum = satir.Cells["Durum"].Value.ToString()
            };

            lblSeciliIstekBilgi.Text = $"Seçili: {seciliIstek.UrunAdi} ({seciliIstek.Fiyat:N2} TL)";
        }

        private void btnYeniIstekAc_Click(object sender, EventArgs e)
        {
            FormYeniIstek yeniForm = new FormYeniIstek();
            yeniForm.Show();
            this.Hide();
        }

        private void btnIstekGuncelleAc_Click(object sender, EventArgs e)
        {
            if (seciliIstek == null)
            {
                MessageBox.Show("Lütfen önce tablodan güncellemek istediğiniz isteği seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormYeniIstek guncelleForm = new FormYeniIstek(seciliIstek);
            guncelleForm.Show();
            this.Hide();
        }

        private void btnVazgecildi_Click(object sender, EventArgs e)
        {
            if (seciliIstek == null)
            {
                MessageBox.Show("Lütfen önce tablodan bir istek seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (istekController.IstekDurumGuncelle(seciliIstek.IstekID, FormGiris.AktifKullanici.KullaniciID, "Vazgeçildi"))
                {
                    MessageBox.Show($"Harika karar! '{seciliIstek.UrunAdi}' ürününden vazgeçtiniz ve tutarı tasarruf hanenize eklendi.", "Tasarruf Kaydedildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSatinAlindi_Click(object sender, EventArgs e)
        {
            if (seciliIstek == null)
            {
                MessageBox.Show("Lütfen önce tablodan bir istek seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (istekController.IstekDurumGuncelle(seciliIstek.IstekID, FormGiris.AktifKullanici.KullaniciID, "Satın Alındı"))
                {
                    MessageBox.Show($"'{seciliIstek.UrunAdi}' ürünü 'Satın Alındı' olarak güncellendi.", "Durum Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIstekSil_Click(object sender, EventArgs e)
        {
            if (seciliIstek == null)
            {
                MessageBox.Show("Lütfen tablodan silmek istediğiniz isteği seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show($"'{seciliIstek.UrunAdi}' kaydını karantina listesinden kalıcı olarak silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (istekController.IstekSil(seciliIstek.IstekID, FormGiris.AktifKullanici.KullaniciID))
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListeyiYenile();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKarantinaGeriDon_Click(object sender, EventArgs e)
        {
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }
    }
}

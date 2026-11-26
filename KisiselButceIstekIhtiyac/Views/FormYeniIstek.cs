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
    public partial class FormYeniIstek : Form
    {
        private readonly IstekController istekController = new IstekController();
        private readonly Istek duzenlenenIstek = null;
        private decimal hesaplananEmekSaat = 0;

        // Varsayılan (Ekleme) ve Parametreli (Güncelleme) Kurucu Metot
        public FormYeniIstek(Istek istek = null)
        {
            InitializeComponent();
            this.duzenlenenIstek = istek;

            this.Load += new EventHandler(this.FormYeniIstek_Load);
            this.txtIstekFiyat.TextChanged += new EventHandler(this.txtIstekFiyat_TextChanged);
            this.btnKarantinayaEkle.Click += new EventHandler(this.btnKarantinayaEkle_Click);
            this.btnYeniIstekGeriDon.Click += new EventHandler(this.btnYeniIstekGeriDon_Click);
            this.btnKarantinayaGit.Click += new EventHandler(this.btnKarantinayaGit_Click);
        }

        private void FormYeniIstek_Load(object sender, EventArgs e)
        {
            if (cmbIstekKategori.Items.Count > 0)
                cmbIstekKategori.SelectedIndex = 0;

            if (cmbKarantinaGun.Items.Count > 1)
                cmbKarantinaGun.SelectedIndex = 1; // Varsayılan: 7 Gün

            if (FormGiris.AktifKullanici != null)
            {
                lblSaatlikBilgi.Text = $"Mevcut Saatlik Kazancınız: {FormGiris.AktifKullanici.SaatlikKazanc:N2} TL/saat (Günlük {FormGiris.AktifKullanici.GunlukCalismaSaati} saat)";
            }

            // Eğer Güncelleme modunda açıldıysa verileri kutulara doldur
            if (duzenlenenIstek != null)
            {
                this.Text = "İstek Bilgilerini Güncelle";
                btnKarantinayaEkle.Text = "Değişiklikleri Güncelle";

                txtIstekUrunAdi.Text = duzenlenenIstek.UrunAdi;
                txtIstekFiyat.Text = duzenlenenIstek.Fiyat.ToString();

                int katIndex = cmbIstekKategori.Items.IndexOf(duzenlenenIstek.Kategori);
                if (katIndex >= 0) cmbIstekKategori.SelectedIndex = katIndex;
            }
        }

        private void txtIstekFiyat_TextChanged(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null) return;

            decimal saatlikKazanc = FormGiris.AktifKullanici.SaatlikKazanc;
            decimal gunlukMesai = FormGiris.AktifKullanici.GunlukCalismaSaati;

            if (decimal.TryParse(txtIstekFiyat.Text.Trim(), out decimal fiyat) && fiyat > 0 && saatlikKazanc > 0)
            {
                hesaplananEmekSaat = Math.Round(fiyat / saatlikKazanc, 2);
                decimal isGunu = gunlukMesai > 0 ? Math.Round(hesaplananEmekSaat / gunlukMesai, 1) : 0;

                lblEmekSonuc.Text = $"{hesaplananEmekSaat:N2} Saat ({isGunu:N1} İş Günü)";
            }
            else
            {
                hesaplananEmekSaat = 0;
                lblEmekSonuc.Text = "0,00 Saat (0,0 İş Günü)";
            }
        }

        private int SeciliKarantinaGununuGetir()
        {
            switch (cmbKarantinaGun.SelectedIndex)
            {
                case 0: return 3;
                case 1: return 7;
                case 2: return 14;
                case 3: return 30;
                default: return 7;
            }
        }

        private void btnKarantinayaEkle_Click(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null) return;

            if (string.IsNullOrWhiteSpace(txtIstekUrunAdi.Text) || string.IsNullOrWhiteSpace(txtIstekFiyat.Text))
            {
                MessageBox.Show("Lütfen ürün adını ve fiyatını eksiksiz giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtIstekFiyat.Text.Trim(), out decimal fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Lütfen sıfırdan büyük geçerli bir ürün fiyatı giriniz.", "Hatalı Fiyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int beklemeGunu = SeciliKarantinaGununuGetir();

                if (duzenlenenIstek == null)
                {
                    // YENİ EKLEME (CREATE)
                    DateTime simdi = DateTime.Now;
                    DateTime bitisTarihi = simdi.AddDays(beklemeGunu);

                    Istek yeniIstek = new Istek
                    {
                        KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                        UrunAdi = txtIstekUrunAdi.Text.Trim(),
                        Kategori = cmbIstekKategori.SelectedItem.ToString(),
                        Fiyat = fiyat,
                        EmekKarsiligiSaat = hesaplananEmekSaat,
                        EklenmeTarihi = simdi,
                        KarantinaBitisTarihi = bitisTarihi,
                        Durum = "Beklemede"
                    };

                    if (istekController.IstekEkle(yeniIstek))
                    {
                        MessageBox.Show($"'{yeniIstek.UrunAdi}' ürünü {beklemeGunu} günlük karantinaya alındı!\nEmek Karşılığı: {hesaplananEmekSaat:N2} Saat",
                                        "Karantinaya Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIstekUrunAdi.Clear();
                        txtIstekFiyat.Clear();
                    }
                }
                else
                {
                    // MEVCUT KAYDI GÜNCELLEME (UPDATE)
                    duzenlenenIstek.UrunAdi = txtIstekUrunAdi.Text.Trim();
                    duzenlenenIstek.Kategori = cmbIstekKategori.SelectedItem.ToString();
                    duzenlenenIstek.Fiyat = fiyat;
                    duzenlenenIstek.EmekKarsiligiSaat = hesaplananEmekSaat;
                    duzenlenenIstek.KarantinaBitisTarihi = DateTime.Now.AddDays(beklemeGunu);

                    if (istekController.IstekGuncelle(duzenlenenIstek))
                    {
                        MessageBox.Show($"'{duzenlenenIstek.UrunAdi}' kaydı başarıyla güncellendi!", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Güncelleme bitince direkt Karantina listesine dön
                        FormKarantina karantina = new FormKarantina();
                        karantina.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYeniIstekGeriDon_Click(object sender, EventArgs e)
        {
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }

        private void btnKarantinayaGit_Click(object sender, EventArgs e)
        {
            FormKarantina karantina = new FormKarantina();
            karantina.Show();
            this.Hide();
        }
    }
}
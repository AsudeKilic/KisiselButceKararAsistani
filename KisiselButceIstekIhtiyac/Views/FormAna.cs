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

namespace KisiselButceIstekIhtiyac.Views
{
    public partial class FormAna : Form
    {
        private readonly GiderController giderController = new GiderController();
        private readonly IstekController istekController = new IstekController();
        private bool formGecisiYapiliyor = false;

        public FormAna()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormAna_Load);
            this.FormClosed += new FormClosedEventHandler(this.FormAna_FormClosed);
            this.btnMenuGenelBakis.Click += new EventHandler(this.btnMenuGenelBakis_Click);
            this.btnMenuZorunluGider.Click += new EventHandler(this.btnMenuZorunluGider_Click);
            this.btnMenuYeniIstek.Click += new EventHandler(this.btnMenuYeniIstek_Click);
            this.btnMenuKarantina.Click += new EventHandler(this.btnMenuKarantina_Click);
            this.btnMenuHedefler.Click += new EventHandler(this.btnMenuHedefler_Click);
            this.btnMenuKullaniciYonetimi.Click += new EventHandler(this.btnMenuKullaniciYonetimi_Click);
            this.btnCikisYap.Click += new EventHandler(this.btnCikisYap_Click);
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null)
            {
                formGecisiYapiliyor = true;
                FormGiris giris = new FormGiris();
                giris.Show();
                this.Close();
                return;
            }

            btnMenuGenelBakis.Cursor = Cursors.Hand;
            btnMenuZorunluGider.Cursor = Cursors.Hand;
            btnMenuYeniIstek.Cursor = Cursors.Hand;
            btnMenuKarantina.Cursor = Cursors.Hand;
            btnMenuHedefler.Cursor = Cursors.Hand;
            btnMenuKullaniciYonetimi.Cursor = Cursors.Hand;
            btnCikisYap.Cursor = Cursors.Hand;

            // Rol bazlı menü görünürlüğü: Sadece Admin ise Kullanıcı Yönetimi butonu görünür
            btnMenuKullaniciYonetimi.Visible = (FormGiris.AktifKullanici.Rol == "Admin");

            lblHosGeldin.Text = $"Hoş Geldin, {FormGiris.AktifKullanici.KullaniciAdi}";
            TabloStiliniUygula();
            FinansalOzetiYukle();
        }

        private void TabloStiliniUygula()
        {
            dgvSonHareketler.EnableHeadersVisualStyles = false;
            dgvSonHareketler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(78, 52, 46);
            dgvSonHareketler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSonHareketler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvSonHareketler.ColumnHeadersHeight = 32;
            dgvSonHareketler.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvSonHareketler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 225, 215);
            dgvSonHareketler.DefaultCellStyle.SelectionForeColor = Color.FromArgb(78, 52, 46);
            dgvSonHareketler.RowTemplate.Height = 28;
        }

        private void FinansalOzetiYukle()
        {
            try
            {
                int kullaniciId = FormGiris.AktifKullanici.KullaniciID;
                decimal aylikMaas = FormGiris.AktifKullanici.AylikNetMaas;
                decimal saatlikKazanc = FormGiris.AktifKullanici.SaatlikKazanc;

                decimal toplamGider = giderController.ToplamGiderGetir(kullaniciId);
                decimal kalanButce = aylikMaas - toplamGider;
                decimal bekleyenKarantina = istekController.BekleyenKarantinaToplamGetir(kullaniciId);
                decimal toplamTasarruf = istekController.VazgecilenToplamTasarrufGetir(kullaniciId);

                lblOzetMaas.Text = $"{aylikMaas:N2} TL";
                lblOzetSaatlik.Text = $"{saatlikKazanc:N2} TL / sa";
                lblOzetGider.Text = $"{toplamGider:N2} TL";
                lblOzetKalanButce.Text = $"{kalanButce:N2} TL";
                lblOzetKarantina.Text = $"{bekleyenKarantina:N2} TL";
                lblOzetTasarruf.Text = $"{toplamTasarruf:N2} TL";

                lblOzetKalanButce.ForeColor = kalanButce < 0
                    ? Color.FromArgb(192, 57, 43)
                    : Color.FromArgb(39, 174, 96);

                dgvSonHareketler.DataSource = istekController.IstekleriGetir(kullaniciId, "Tümü");
                if (dgvSonHareketler.Columns["IstekID"] != null)
                    dgvSonHareketler.Columns["IstekID"].Visible = false;
                if (dgvSonHareketler.Columns["Eklenme Tarihi"] != null)
                    dgvSonHareketler.Columns["Eklenme Tarihi"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Finansal özet hesaplanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuGenelBakis_Click(object sender, EventArgs e)
        {
            FinansalOzetiYukle();
        }

        private void btnMenuZorunluGider_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormZorunluGider giderForm = new FormZorunluGider();
            giderForm.Show();
            this.Hide();
        }

        private void btnMenuYeniIstek_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormYeniIstek istekForm = new FormYeniIstek();
            istekForm.Show();
            this.Hide();
        }

        private void btnMenuKarantina_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormKarantina karantinaForm = new FormKarantina();
            karantinaForm.Show();
            this.Hide();
        }

        private void btnMenuHedefler_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormHedef hedefForm = new FormHedef();
            hedefForm.Show();
            this.Hide();
        }

        private void btnMenuKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormAdmin adminForm = new FormAdmin();
            adminForm.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Hesabınızdan çıkış yapmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                FormGiris.AktifKullanici = null;
                formGecisiYapiliyor = true;
                FormGiris giris = new FormGiris();
                giris.Show();
                this.Hide();
            }
        }

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!formGecisiYapiliyor)
            {
                Application.Exit();
            }
        }
    }
}
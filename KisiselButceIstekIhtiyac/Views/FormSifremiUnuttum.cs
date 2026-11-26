using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using KisiselButceIstekIhtiyac.Controllers;

namespace KisiselButceIstekIhtiyac.Views
{
    public partial class FormSifremiUnuttum : Form
    {
        private readonly UserController userController = new UserController();
        private string uretilenKod = "";
        private string dogrulananEmail = "";
        private bool formGecisiYapiliyor = false;

        public FormSifremiUnuttum()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormSifremiUnuttum_Load);
            this.FormClosed += new FormClosedEventHandler(this.FormSifremiUnuttum_FormClosed);
            this.btnKodGonder.Click += new EventHandler(this.btnKodGonder_Click);
            this.btnSifreGuncelle.Click += new EventHandler(this.btnSifreGuncelle_Click);
            this.btnGirisDon.Click += new EventHandler(this.btnGirisDon_Click);
        }

        private void FormSifremiUnuttum_Load(object sender, EventArgs e)
        {
            btnKodGonder.Cursor = Cursors.Hand;
            btnSifreGuncelle.Cursor = Cursors.Hand;
            btnGirisDon.Cursor = Cursors.Hand;

            txtDogrulamaKodu.Enabled = false;
            txtYeniSifre.Enabled = false;
            txtYeniSifreTekrar.Enabled = false;
            btnSifreGuncelle.Enabled = false;
        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            string email = txtSifreUnuttumEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Lütfen kayıtlı e-mail adresinizi giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!userController.EmailKayitliMi(email))
                {
                    MessageBox.Show("Bu e-mail adresi ile kayıtlı bir kullanıcı bulunamadı.", "Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Random rnd = new Random();
                uretilenKod = rnd.Next(100000, 999999).ToString();

                if (userController.DogrulamaKoduGonder(email, uretilenKod))
                {
                    dogrulananEmail = email;
                    txtSifreUnuttumEmail.Enabled = false;
                    btnKodGonder.Enabled = false;

                    txtDogrulamaKodu.Enabled = true;
                    txtYeniSifre.Enabled = true;
                    txtYeniSifreTekrar.Enabled = true;
                    btnSifreGuncelle.Enabled = true;

                    MessageBox.Show("6 haneli doğrulama kodu e-mail adresinize gönderildi.", "Kod Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            string girilenKod = txtDogrulamaKodu.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreTekrar = txtYeniSifreTekrar.Text.Trim();

            if (string.IsNullOrWhiteSpace(girilenKod) || string.IsNullOrWhiteSpace(yeniSifre) || string.IsNullOrWhiteSpace(yeniSifreTekrar))
            {
                MessageBox.Show("Lütfen doğrulama kodunu ve yeni şifre alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (girilenKod != uretilenKod)
            {
                MessageBox.Show("Girdiğiniz doğrulama kodu hatalı! Lütfen e-mailinizi kontrol ediniz.", "Hatalı Kod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Girdiğiniz yeni şifreler birbiriyle uyuşmuyor.", "Şifre Uyuşmazlığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (userController.SifreGuncelle(dogrulananEmail, yeniSifre))
                {
                    MessageBox.Show("Şifreniz başarıyla güncellendi. Yeni şifrenizle giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formGecisiYapiliyor = true;
                    FormGiris giris = new FormGiris();
                    giris.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            formGecisiYapiliyor = true;
            FormGiris giris = new FormGiris();
            giris.Show();
            this.Hide();
        }

        private void FormSifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!formGecisiYapiliyor)
            {
                Application.Exit();
            }
        }
    }
}
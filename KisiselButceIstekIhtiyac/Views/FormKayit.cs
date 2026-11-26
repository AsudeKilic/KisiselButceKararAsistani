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
    public partial class FormKayit : Form
    {
        private readonly UserController userController = new UserController();

        public FormKayit()
        {
            InitializeComponent();
            this.btnKayitOl.Click += new EventHandler(this.btnKayitOl_Click);
            this.lnkGirisYap.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkGirisYap_LinkClicked);
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kadi = txtKayKullaniciAdi.Text.Trim();
            string email = txtKayEmail.Text.Trim();
            string sifre = txtKaySifre.Text.Trim();

            if (string.IsNullOrEmpty(kadi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre) ||
                string.IsNullOrEmpty(txtKayMaas.Text) || string.IsNullOrEmpty(txtKayMesai.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtKayMaas.Text, out decimal maas) || !decimal.TryParse(txtKayMesai.Text, out decimal mesai) || maas <= 0 || mesai <= 0)
            {
                MessageBox.Show("Maaş ve günlük mesai saati sıfırdan büyük sayısal değerler olmalıdır.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (userController.KullaniciVeyaEmailVarMi(kadi, email))
                {
                    MessageBox.Show("Bu kullanıcı adı veya e-posta adresi sistemde zaten kayıtlı!", "Kayıt Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User adayKullanici = new User
                {
                    KullaniciAdi = kadi,
                    Email = email,
                    Sifre = sifre,
                    AylikNetMaas = maas,
                    GunlukCalismaSaati = mesai
                };

                string gonderilenKod = userController.DogrulamaKoduGonder(email);
                MessageBox.Show("E-posta adresinize 6 haneli doğrulama kodu gönderildi.", "Kod Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormDogrulama dogrulama = new FormDogrulama("KayitOnay", adayKullanici, gonderilenKod);
                dogrulama.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGiris giris = new FormGiris();
            giris.Show();
            this.Hide();
        }
    }
}
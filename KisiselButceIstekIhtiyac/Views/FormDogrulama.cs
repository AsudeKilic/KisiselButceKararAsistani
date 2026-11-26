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
    public partial class FormDogrulama : Form
    {
        private readonly UserController userController = new UserController();
        private string islemModu; // "KayitOnay" veya "SifreSifirlama"
        private User bekleyenKullanici;
        private string aktifDogrulamaKodu;

        public FormDogrulama(string mod, User kullanici, string gonderilenKod = "")
        {
            InitializeComponent();
            this.islemModu = mod;
            this.bekleyenKullanici = kullanici;
            this.aktifDogrulamaKodu = gonderilenKod;

            this.btnKodGonder.Click += new EventHandler(this.btnKodGonder_Click);
            this.btnDogrula.Click += new EventHandler(this.btnDogrula_Click);
            this.lnkGeriDon.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkGeriDon_LinkClicked);

            EkraniModaGoreAyarla();
        }

        private void EkraniModaGoreAyarla()
        {
            if (islemModu == "KayitOnay" && bekleyenKullanici != null)
            {
                txtDogrulamaEmail.Text = bekleyenKullanici.Email;
                txtDogrulamaEmail.ReadOnly = true;
                lblYeniSifre.Visible = false;
                txtYeniSifre.Visible = false;
                btnDogrula.Text = "Hesabı Doğrula ve Tamamla";
            }
            else
            {
                txtDogrulamaEmail.ReadOnly = false;
                lblYeniSifre.Visible = true;
                txtYeniSifre.Visible = true;
                btnDogrula.Text = "Kodu Doğrula ve Şifreyi Güncelle";
            }
        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            string email = txtDogrulamaEmail.Text.Trim();
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (islemModu == "SifreSifirlama" && !userController.EmailKayitliMi(email))
                {
                    MessageBox.Show("Bu e-posta adresine kayıtlı bir hesap bulunamadı!", "Kayıt Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                aktifDogrulamaKodu = userController.DogrulamaKoduGonder(email);
                MessageBox.Show("6 haneli doğrulama kodu e-posta adresinize gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "E-posta Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            string girilenKod = txtKod.Text.Trim();

            if (string.IsNullOrEmpty(aktifDogrulamaKodu))
            {
                MessageBox.Show("Lütfen önce 'Kod Gönder' butonuna basarak kod isteyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (girilenKod != aktifDogrulamaKodu)
            {
                MessageBox.Show("Girdiğiniz 6 haneli doğrulama kodu hatalı! Lütfen e-postanızı kontrol ediniz.", "Hatalı Kod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (islemModu == "KayitOnay")
                {
                    bool kayitBasarili = userController.KayitOl(bekleyenKullanici);
                    if (kayitBasarili)
                    {
                        MessageBox.Show("E-posta doğrulandı ve hesabınız başarıyla oluşturuldu! Şimdi giriş yapabilirsiniz.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormGiris giris = new FormGiris();
                        giris.Show();
                        this.Hide();
                    }
                }
                else
                {
                    string yeniSifre = txtYeniSifre.Text.Trim();
                    if (string.IsNullOrEmpty(yeniSifre))
                    {
                        MessageBox.Show("Lütfen belirlemek istediğiniz yeni şifreyi giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool guncellendi = userController.SifreGuncelle(txtDogrulamaEmail.Text.Trim(), yeniSifre);
                    if (guncellendi)
                    {
                        MessageBox.Show("Şifreniz başarıyla güncellendi! Yeni şifrenizle giriş yapabilirsiniz.", "Şifre Değiştirildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormGiris giris = new FormGiris();
                        giris.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormGiris giris = new FormGiris();
            giris.Show();
            this.Hide();
        }
    }
}
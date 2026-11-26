using System;
using System.Windows.Forms;
using KisiselButceIstekIhtiyac.Controllers;
using KisiselButceIstekIhtiyac.Models;

namespace KisiselButceIstekIhtiyac.Views
{
    public partial class FormGiris : Form
    {
        private readonly UserController userController = new UserController();
        public static User AktifKullanici = null;

        public FormGiris()
        {
            InitializeComponent();

            this.btnGiris.Click += new EventHandler(this.btnGiris_Click);
            this.lnkKayitOl.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkKayitOl_LinkClicked);
            this.lnkSifremiUnuttum.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSifremiUnuttum_LinkClicked);
            this.FormClosed += new FormClosedEventHandler(this.FormGiris_FormClosed);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AktifKullanici = userController.GirisYap(kullaniciAdi, sifre);

                if (AktifKullanici != null)
                {
                    FormAna anaSayfa = new FormAna();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayit kayitForm = new FormKayit();
            kayitForm.Show();
            this.Hide();
        }

        private void lnkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSifremiUnuttum sifreForm = new FormSifremiUnuttum();
            sifreForm.Show();
            this.Hide();
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
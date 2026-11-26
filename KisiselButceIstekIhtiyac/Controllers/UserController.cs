using System;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using KisiselButceIstekIhtiyac.Database;
using KisiselButceIstekIhtiyac.Models;

namespace KisiselButceIstekIhtiyac.Controllers
{
    public class UserController
    {
        private readonly DbConnection db = new DbConnection();

        // 1. KULLANICI GİRİŞ DOĞRULAMA
        public User GirisYap(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @kadi AND Sifre = @sifre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                KullaniciID = Convert.ToInt32(reader["KullaniciID"]),
                                KullaniciAdi = reader["KullaniciAdi"].ToString(),
                                Email = reader["Email"].ToString(),
                                Sifre = reader["Sifre"].ToString(),
                                AylikNetMaas = Convert.ToDecimal(reader["AylikNetMaas"]),
                                GunlukCalismaSaati = Convert.ToDecimal(reader["GunlukCalismaSaati"]),
                                SaatlikKazanc = Convert.ToDecimal(reader["SaatlikKazanc"]),
                                Rol = reader["Rol"] != DBNull.Value ? reader["Rol"].ToString() : "Kullanici"
                            };
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Giriş işlemi sırasında veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 2. KULLANICI ADI VEYA E-MAIL KONTROLÜ (FormKayit.cs için)
        public bool KullaniciVeyaEmailVarMi(string kullaniciAdi, string email)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @kadi OR Email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@email", email);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı kontrolü sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        public bool KullaniciVarMi(string kullaniciAdi, string email)
        {
            return KullaniciVeyaEmailVarMi(kullaniciAdi, email);
        }

        // 3. YENİ KULLANICI KAYDI
        public bool KayitOl(User yeniUser)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    decimal saatlikKazanc = Math.Round(yeniUser.AylikNetMaas / (yeniUser.GunlukCalismaSaati * 22), 2);
                    string rol = string.IsNullOrWhiteSpace(yeniUser.Rol) ? "Kullanici" : yeniUser.Rol;

                    string query = @"INSERT INTO Kullanicilar 
                                     (KullaniciAdi, Email, Sifre, AylikNetMaas, GunlukCalismaSaati, SaatlikKazanc, Rol) 
                                     VALUES (@kadi, @email, @sifre, @maas, @mesai, @saatlik, @rol)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kadi", yeniUser.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@email", yeniUser.Email);
                    cmd.Parameters.AddWithValue("@sifre", yeniUser.Sifre);
                    cmd.Parameters.AddWithValue("@maas", yeniUser.AylikNetMaas);
                    cmd.Parameters.AddWithValue("@mesai", yeniUser.GunlukCalismaSaati);
                    cmd.Parameters.AddWithValue("@saatlik", saatlikKazanc);
                    cmd.Parameters.AddWithValue("@rol", rol);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Kayıt işlemi sırasında veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 4. E-MAIL SİSTEMDE KAYITLI MI KONTROLÜ (Şifremi Unuttum için)
        public bool EmailKayitliMi(string email)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("E-mail sorgulanırken hata oluştu: " + ex.Message);
                }
            }
        }

        // 5. E-MAIL ÜZERİNDEN ŞİFRE GÜNCELLEME
        public bool SifreGuncelle(string email, string yeniSifre)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Kullanicilar SET Sifre = @sifre WHERE Email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sifre", yeniSifre);
                    cmd.Parameters.AddWithValue("@email", email);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Şifre güncellenirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 6A. DOĞRULAMA KODU GÖNDERİMİ (1 Parametreli - FormKayit ve FormDogrulama için)
        public string DogrulamaKoduGonder(string aliciEmail)
        {
            Random rnd = new Random();
            string uretilenKod = rnd.Next(100000, 999999).ToString();
            DogrulamaKoduGonder(aliciEmail, uretilenKod);
            return uretilenKod;
        }

        // 6B. DOĞRULAMA KODU GÖNDERİMİ (2 Parametreli - FormSifremiUnuttum için)
        public bool DogrulamaKoduGonder(string aliciEmail, string kod)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Kendi Gmail adresini ve 16 haneli Uygulama Şifreni buraya yaz
                string gonderenEmail = "ornek_mail@gmail.com";
                string uygulamaSifresi = "GMAIL_UYGULAMA_SIFRENIZI_GIRINIZ";

                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress(gonderenEmail, "Kişisel Bütçe ve Karar Asistanı");
                mesaj.To.Add(new MailAddress(aliciEmail));
                mesaj.Subject = "Doğrulama Kodunuz - Kişisel Bütçe ve Karar Asistanı";
                mesaj.Body = $"Merhaba,\n\nİşleminizi tamamlamak için 6 haneli doğrulama kodunuz: {kod}\n\nİyi günler dileriz.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(gonderenEmail, uygulamaSifresi);
                smtp.EnableSsl = true;
                smtp.Send(mesaj);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Doğrulama e-postası gönderilemedi: " + ex.Message);
            }
        }
    }
}

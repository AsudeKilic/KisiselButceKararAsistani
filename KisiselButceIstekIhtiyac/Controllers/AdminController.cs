using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using KisiselButceIstekIhtiyac.Database;
using KisiselButceIstekIhtiyac.Models;

namespace KisiselButceIstekIhtiyac.Controllers
{
    public class AdminController
    {
        private readonly DbConnection db = new DbConnection();

        // 1. TÜM KAYITLI KULLANICILARI LİSTELEME (READ)
        public DataTable TumKullanicilariGetir()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT KullaniciID, 
                                            KullaniciAdi AS 'Kullanıcı Adı', 
                                            Email AS 'E-Mail', 
                                            Sifre AS 'Şifre', 
                                            AylikNetMaas AS 'Aylık Maaş (TL)', 
                                            GunlukCalismaSaati AS 'Günlük Mesai (Saat)', 
                                            SaatlikKazanc AS 'Saatlik Kazanç (TL)', 
                                            Rol 
                                    FROM Kullanicilar 
                                    ORDER BY KullaniciID ASC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı listesi getirilirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
            return dt;
        }

        // 2. ADMİN TARAFINDAN YENİ KULLANICI EKLEME (CREATE)
        public bool KullaniciEkle(User yeniUser)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string kontrolQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE KullaniciAdi = @kadi OR Email = @email";
                    MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, conn);
                    kontrolCmd.Parameters.AddWithValue("@kadi", yeniUser.KullaniciAdi);
                    kontrolCmd.Parameters.AddWithValue("@email", yeniUser.Email);

                    if (Convert.ToInt32(kontrolCmd.ExecuteScalar()) > 0)
                    {
                        throw new Exception("Bu kullanıcı adı veya e-posta adresi sistemde zaten kayıtlıdır.");
                    }

                    decimal saatlikKazanc = Math.Round(yeniUser.AylikNetMaas / (yeniUser.GunlukCalismaSaati * 22), 2);

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
                    cmd.Parameters.AddWithValue("@rol", yeniUser.Rol);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        // 3. KULLANICI BİLGİLERİNİ VE ROLÜNÜ GÜNCELLEME (UPDATE)
        public bool KullaniciGuncelle(User guncelUser)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string kontrolQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE (KullaniciAdi = @kadi OR Email = @email) AND KullaniciID != @id";
                    MySqlCommand kontrolCmd = new MySqlCommand(kontrolQuery, conn);
                    kontrolCmd.Parameters.AddWithValue("@kadi", guncelUser.KullaniciAdi);
                    kontrolCmd.Parameters.AddWithValue("@email", guncelUser.Email);
                    kontrolCmd.Parameters.AddWithValue("@id", guncelUser.KullaniciID);

                    if (Convert.ToInt32(kontrolCmd.ExecuteScalar()) > 0)
                    {
                        throw new Exception("Girilen kullanıcı adı veya e-posta başka bir kullanıcı tarafından kullanılıyor.");
                    }

                    decimal saatlikKazanc = Math.Round(guncelUser.AylikNetMaas / (guncelUser.GunlukCalismaSaati * 22), 2);

                    string query = @"UPDATE Kullanicilar 
                                     SET KullaniciAdi = @kadi, 
                                         Email = @email, 
                                         Sifre = @sifre, 
                                         AylikNetMaas = @maas, 
                                         GunlukCalismaSaati = @mesai, 
                                         SaatlikKazanc = @saatlik, 
                                         Rol = @rol 
                                     WHERE KullaniciID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kadi", guncelUser.KullaniciAdi);
                    cmd.Parameters.AddWithValue("@email", guncelUser.Email);
                    cmd.Parameters.AddWithValue("@sifre", guncelUser.Sifre);
                    cmd.Parameters.AddWithValue("@maas", guncelUser.AylikNetMaas);
                    cmd.Parameters.AddWithValue("@mesai", guncelUser.GunlukCalismaSaati);
                    cmd.Parameters.AddWithValue("@saatlik", saatlikKazanc);
                    cmd.Parameters.AddWithValue("@rol", guncelUser.Rol);
                    cmd.Parameters.AddWithValue("@id", guncelUser.KullaniciID);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        // 4. KAYITLI KULLANICIYI SİLME (DELETE)
        public bool KullaniciSil(int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Kullanicilar WHERE KullaniciID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Kullanıcı silinirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }
    }
}
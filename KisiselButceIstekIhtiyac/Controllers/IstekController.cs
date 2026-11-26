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
    public class IstekController
    {
        private readonly DbConnection db = new DbConnection();

        // 1. YENİ İSTEK EKLEME / KARANTİNAYA ALMA (CREATE)
        public bool IstekEkle(Istek yeniIstek)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO IstekKarantinasi 
                                     (KullaniciID, UrunAdi, Kategori, Fiyat, EmekKarsiligiSaat, EklenmeTarihi, KarantinaBitisTarihi, Durum) 
                                     VALUES (@kullaniciId, @urunAdi, @kategori, @fiyat, @emekSaat, @eklenmeTarihi, @bitisTarihi, @durum)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", yeniIstek.KullaniciID);
                    cmd.Parameters.AddWithValue("@urunAdi", yeniIstek.UrunAdi);
                    cmd.Parameters.AddWithValue("@kategori", yeniIstek.Kategori);
                    cmd.Parameters.AddWithValue("@fiyat", yeniIstek.Fiyat);
                    cmd.Parameters.AddWithValue("@emekSaat", yeniIstek.EmekKarsiligiSaat);
                    cmd.Parameters.AddWithValue("@eklenmeTarihi", yeniIstek.EklenmeTarihi);
                    cmd.Parameters.AddWithValue("@bitisTarihi", yeniIstek.KarantinaBitisTarihi);
                    cmd.Parameters.AddWithValue("@durum", yeniIstek.Durum);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("İstek karantinaya eklenirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 2. KULLANICININ KARANTİNADAKİ İSTEKLERİNİ LİSTELEME (READ - Filtreleme Destekli)
        public DataTable IstekleriGetir(int kullaniciId, string durumFiltresi = "Tümü")
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT IstekID, 
                                            UrunAdi AS 'Ürün Adı', 
                                            Kategori, 
                                            Fiyat AS 'Fiyat (TL)', 
                                            EmekKarsiligiSaat AS 'Emek Karşılığı (Saat)', 
                                            EklenmeTarihi AS 'Eklenme Tarihi', 
                                            KarantinaBitisTarihi AS 'Karantina Bitiş', 
                                            Durum 
                                     FROM IstekKarantinasi 
                                     WHERE KullaniciID = @kullaniciId";

                    if (durumFiltresi != "Tümü")
                    {
                        query += " AND Durum = @durum";
                    }

                    query += " ORDER BY KarantinaBitisTarihi ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    if (durumFiltresi != "Tümü")
                    {
                        cmd.Parameters.AddWithValue("@durum", durumFiltresi);
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Karantina listesi getirilirken hata oluştu: " + ex.Message);
                }
            }
            return dt;
        }

        // 3. İSTEK DURUMUNU VEYA BİLGİLERİNİ GÜNCELLEME (UPDATE)
        public bool IstekDurumGuncelle(int istekId, int kullaniciId, string yeniDurum)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE IstekKarantinasi 
                                     SET Durum = @yeniDurum 
                                     WHERE IstekID = @istekId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@yeniDurum", yeniDurum);
                    cmd.Parameters.AddWithValue("@istekId", istekId);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("İstek durumu güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 4. SEÇİLİ İSTEĞİ KARANTİNADAN SİLME (DELETE)
        public bool IstekSil(int istekId, int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM IstekKarantinasi WHERE IstekID = @istekId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@istekId", istekId);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("İstek kaydı silinirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 5. VAZGEÇİLEN İSTEKLERDEN TASARRUF EDİLEN TOPLAM TUTAR (Dashboard İçin)
        public decimal VazgecilenToplamTasarrufGetir(int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(SUM(Fiyat), 0) FROM IstekKarantinasi WHERE KullaniciID = @kullaniciId AND Durum = 'Vazgeçildi'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception("Tasarruf tutarı hesaplanırken hata oluştu: " + ex.Message);
                }
            }
        }

        // 6. BEKLEMEDEKİ TOPLAM KARANTİNA TUTARI (Dashboard İçin)
        public decimal BekleyenKarantinaToplamGetir(int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(SUM(Fiyat), 0) FROM IstekKarantinasi WHERE KullaniciID = @kullaniciId AND Durum = 'Beklemede'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception("Bekleyen karantina tutarı hesaplanırken hata oluştu: " + ex.Message);
                }
            }
        }
        // 7. İSTEK BİLGİLERİNİ TAM GÜNCELLEME (UPDATE - Ürün Adı, Kategori, Fiyat, Emek, Bitiş Tarihi)
        public bool IstekGuncelle(Istek guncelIstek)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE IstekKarantinasi 
                                     SET UrunAdi = @urunAdi, 
                                         Kategori = @kategori, 
                                         Fiyat = @fiyat, 
                                         EmekKarsiligiSaat = @emekSaat, 
                                         KarantinaBitisTarihi = @bitisTarihi 
                                     WHERE IstekID = @istekId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@urunAdi", guncelIstek.UrunAdi);
                    cmd.Parameters.AddWithValue("@kategori", guncelIstek.Kategori);
                    cmd.Parameters.AddWithValue("@fiyat", guncelIstek.Fiyat);
                    cmd.Parameters.AddWithValue("@emekSaat", guncelIstek.EmekKarsiligiSaat);
                    cmd.Parameters.AddWithValue("@bitisTarihi", guncelIstek.KarantinaBitisTarihi);
                    cmd.Parameters.AddWithValue("@istekId", guncelIstek.IstekID);
                    cmd.Parameters.AddWithValue("@kullaniciId", guncelIstek.KullaniciID);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("İstek güncellenirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }
    }
}
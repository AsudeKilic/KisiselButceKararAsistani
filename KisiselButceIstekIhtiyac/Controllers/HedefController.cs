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
    public class HedefController
    {
        private readonly DbConnection db = new DbConnection();

        // 1. YENİ HEDEF EKLEME (CREATE)
        public bool HedefEkle(Hedef yeniHedef)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string durum = yeniHedef.BirikenTutar >= yeniHedef.HedefTutar ? "Tamamlandı" : "Devam Ediyor";

                    string query = @"INSERT INTO Hedefler (KullaniciID, HedefAdi, HedefTutar, BirikenTutar, HedefTarih, Durum) 
                                     VALUES (@kullaniciId, @hedefAdi, @hedefTutar, @birikenTutar, @hedefTarih, @durum)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", yeniHedef.KullaniciID);
                    cmd.Parameters.AddWithValue("@hedefAdi", yeniHedef.HedefAdi);
                    cmd.Parameters.AddWithValue("@hedefTutar", yeniHedef.HedefTutar);
                    cmd.Parameters.AddWithValue("@birikenTutar", yeniHedef.BirikenTutar);
                    cmd.Parameters.AddWithValue("@hedefTarih", yeniHedef.HedefTarih);
                    cmd.Parameters.AddWithValue("@durum", durum);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hedef eklenirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 2. KULLANICININ HEDEFLERİNİ LİSTELEME (READ - Yüzde Hesaplamalı)
        public DataTable HedefleriGetir(int kullaniciId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT HedefID, 
                                            HedefAdi AS 'Hedef Adı', 
                                            HedefTutar AS 'Hedef Tutar (TL)', 
                                            BirikenTutar AS 'Biriken (TL)',
                                            ROUND((BirikenTutar / HedefTutar) * 100, 1) AS 'Tamamlanma (%)',
                                            HedefTarih AS 'Hedef Tarih', 
                                            Durum 
                                     FROM Hedefler 
                                     WHERE KullaniciID = @kullaniciId 
                                     ORDER BY HedefTarih ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Hedefler listelenirken hata oluştu: " + ex.Message);
                }
            }
            return dt;
        }

        // 3. MEVCUT HEDEFİ VE BİRİKİMİ GÜNCELLEME (UPDATE)
        public bool HedefGuncelle(Hedef guncelHedef)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string durum = guncelHedef.BirikenTutar >= guncelHedef.HedefTutar ? "Tamamlandı" : "Devam Ediyor";

                    string query = @"UPDATE Hedefler 
                                     SET HedefAdi = @hedefAdi, 
                                         HedefTutar = @hedefTutar, 
                                         BirikenTutar = @birikenTutar, 
                                         HedefTarih = @hedefTarih, 
                                         Durum = @durum 
                                     WHERE HedefID = @hedefId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hedefAdi", guncelHedef.HedefAdi);
                    cmd.Parameters.AddWithValue("@hedefTutar", guncelHedef.HedefTutar);
                    cmd.Parameters.AddWithValue("@birikenTutar", guncelHedef.BirikenTutar);
                    cmd.Parameters.AddWithValue("@hedefTarih", guncelHedef.HedefTarih);
                    cmd.Parameters.AddWithValue("@durum", durum);
                    cmd.Parameters.AddWithValue("@hedefId", guncelHedef.HedefID);
                    cmd.Parameters.AddWithValue("@kullaniciId", guncelHedef.KullaniciID);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hedef güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 4. SEÇİLİ HEDEFİ SİLME (DELETE)
        public bool HedefSil(int hedefId, int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Hedefler WHERE HedefID = @hedefId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@hedefId", hedefId);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hedef silinirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
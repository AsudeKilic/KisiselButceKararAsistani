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
    public class GiderController
    {
        private readonly DbConnection db = new DbConnection();

        // 1. YENİ GİDER EKLEME (CREATE)
        public bool GiderEkle(Gider yeniGider)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Giderler (KullaniciID, GiderAdi, GiderTuru, Tutar, Tarih) 
                                     VALUES (@kullaniciId, @giderAdi, @giderTuru, @tutar, @tarih)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", yeniGider.KullaniciID);
                    cmd.Parameters.AddWithValue("@giderAdi", yeniGider.GiderAdi);
                    cmd.Parameters.AddWithValue("@giderTuru", yeniGider.GiderTuru);
                    cmd.Parameters.AddWithValue("@tutar", yeniGider.Tutar);
                    cmd.Parameters.AddWithValue("@tarih", yeniGider.Tarih);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Gider eklenirken veritabanı hatası oluştu: " + ex.Message);
                }
            }
        }

        // 2. KULLANICININ GİDERLERİNİ LİSTELEME (READ - DataTable Olarak)
        public DataTable GiderleriGetir(int kullaniciId)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT GiderID, GiderAdi AS 'Gider Adı', GiderTuru AS 'Gider Türü', 
                                            Tutar AS 'Tutar (TL)', Tarih 
                                     FROM Giderler 
                                     WHERE KullaniciID = @kullaniciId 
                                     ORDER BY Tarih DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Giderler listelenirken hata oluştu: " + ex.Message);
                }
            }
            return dt;
        }

        // 3. MEVCUT GİDERİ GÜNCELLEME (UPDATE)
        public bool GiderGuncelle(Gider guncelGider)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Giderler 
                                     SET GiderAdi = @giderAdi, GiderTuru = @giderTuru, Tutar = @tutar, Tarih = @tarih 
                                     WHERE GiderID = @giderId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@giderAdi", guncelGider.GiderAdi);
                    cmd.Parameters.AddWithValue("@giderTuru", guncelGider.GiderTuru);
                    cmd.Parameters.AddWithValue("@tutar", guncelGider.Tutar);
                    cmd.Parameters.AddWithValue("@tarih", guncelGider.Tarih);
                    cmd.Parameters.AddWithValue("@giderId", guncelGider.GiderID);
                    cmd.Parameters.AddWithValue("@kullaniciId", guncelGider.KullaniciID);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Gider güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 4. SEÇİLİ GİDERİ SİLME (DELETE)
        public bool GiderSil(int giderId, int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Giderler WHERE GiderID = @giderId AND KullaniciID = @kullaniciId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@giderId", giderId);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Gider silinirken hata oluştu: " + ex.Message);
                }
            }
        }

        // 5. TOPLAM GİDER TUTARINI HESAPLAMA
        public decimal ToplamGiderGetir(int kullaniciId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IFNULL(SUM(Tutar), 0) FROM Giderler WHERE KullaniciID = @kullaniciId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw new Exception("Toplam gider hesaplanırken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
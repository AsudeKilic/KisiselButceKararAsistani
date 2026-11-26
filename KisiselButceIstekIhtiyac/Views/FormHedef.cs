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
    public partial class FormHedef : Form
    {
        private readonly HedefController hedefController = new HedefController();
        private readonly IstekController istekController = new IstekController();
        private int seciliHedefId = 0;

        public FormHedef()
        {
            InitializeComponent();

            this.Load += new EventHandler(this.FormHedef_Load);
            this.btnHedefEkle.Click += new EventHandler(this.btnHedefEkle_Click);
            this.btnHedefGuncelle.Click += new EventHandler(this.btnHedefGuncelle_Click);
            this.btnHedefSil.Click += new EventHandler(this.btnHedefSil_Click);
            this.btnHedefTemizle.Click += new EventHandler(this.btnHedefTemizle_Click);
            this.btnAnaSayfaDon.Click += new EventHandler(this.btnAnaSayfaDon_Click);
            this.dgvHedefler.CellClick += new DataGridViewCellEventHandler(this.dgvHedefler_CellClick);
        }

        private void FormHedef_Load(object sender, EventArgs e)
        {
            dtpHedefTarih.Value = DateTime.Now.AddMonths(3);
            ListeyiYenile();
        }

        private void ListeyiYenile()
        {
            if (FormGiris.AktifKullanici == null) return;

            try
            {
                int kullaniciId = FormGiris.AktifKullanici.KullaniciID;
                dgvHedefler.DataSource = hedefController.HedefleriGetir(kullaniciId);

                if (dgvHedefler.Columns["HedefID"] != null)
                    dgvHedefler.Columns["HedefID"].Visible = false;

                decimal tasarruf = istekController.VazgecilenToplamTasarrufGetir(kullaniciId);
                lblKarantinaTasarrufIpucu.Text = $"Karantinadan Gelen Tasarruf: {tasarruf:N2} TL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            seciliHedefId = 0;
            txtHedefAdi.Clear();
            txtHedefTutar.Clear();
            txtBirikenTutar.Text = "0";
            dtpHedefTarih.Value = DateTime.Now.AddMonths(3);
            pbHedefIlerleme.Value = 0;
            lblSeciliHedefIlerleme.Text = "İlerleme durumunu görmek için tablodan bir hedef seçiniz.";
            dgvHedefler.ClearSelection();
        }

        private void btnHedefEkle_Click(object sender, EventArgs e)
        {
            if (FormGiris.AktifKullanici == null) return;

            if (string.IsNullOrWhiteSpace(txtHedefAdi.Text) || string.IsNullOrWhiteSpace(txtHedefTutar.Text))
            {
                MessageBox.Show("Lütfen hedef adını ve hedeflenen tutarı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtHedefTutar.Text.Trim(), out decimal hedefTutar) || hedefTutar <= 0)
            {
                MessageBox.Show("Lütfen sıfırdan büyük geçerli bir hedef tutarı giriniz.", "Hatalı Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal birikenTutar = 0;
            if (!string.IsNullOrWhiteSpace(txtBirikenTutar.Text) && (!decimal.TryParse(txtBirikenTutar.Text.Trim(), out birikenTutar) || birikenTutar < 0))
            {
                MessageBox.Show("Biriken tutar negatif olamaz.", "Hatalı Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Hedef yeniHedef = new Hedef
                {
                    KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                    HedefAdi = txtHedefAdi.Text.Trim(),
                    HedefTutar = hedefTutar,
                    BirikenTutar = birikenTutar,
                    HedefTarih = dtpHedefTarih.Value
                };

                if (hedefController.HedefEkle(yeniHedef))
                {
                    MessageBox.Show("Yeni finansal hedef başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHedefler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvHedefler.Rows[e.RowIndex].IsNewRow)
                return;

            DataGridViewRow satir = dgvHedefler.Rows[e.RowIndex];

            if (satir.Cells["HedefID"].Value == null || satir.Cells["HedefID"].Value == DBNull.Value)
                return;

            seciliHedefId = Convert.ToInt32(satir.Cells["HedefID"].Value);
            string hedefAdi = satir.Cells["Hedef Adı"].Value.ToString();
            decimal hedefTutar = Convert.ToDecimal(satir.Cells["Hedef Tutar (TL)"].Value);
            decimal birikenTutar = Convert.ToDecimal(satir.Cells["Biriken (TL)"].Value);
            decimal yuzde = Convert.ToDecimal(satir.Cells["Tamamlanma (%)"].Value);

            txtHedefAdi.Text = hedefAdi;
            txtHedefTutar.Text = hedefTutar.ToString();
            txtBirikenTutar.Text = birikenTutar.ToString();
            dtpHedefTarih.Value = Convert.ToDateTime(satir.Cells["Hedef Tarih"].Value);

            int barDegeri = (int)Math.Min(100, Math.Max(0, Math.Round(yuzde)));
            pbHedefIlerleme.Value = barDegeri;
            lblSeciliHedefIlerleme.Text = $"{hedefAdi}: {birikenTutar:N2} / {hedefTutar:N2} TL (%{yuzde:N1} Tamamlandı)";
        }

        private void btnHedefGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliHedefId == 0)
            {
                MessageBox.Show("Lütfen tablodan güncellemek istediğiniz hedefi seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHedefAdi.Text) ||
                !decimal.TryParse(txtHedefTutar.Text.Trim(), out decimal hedefTutar) || hedefTutar <= 0 ||
                !decimal.TryParse(txtBirikenTutar.Text.Trim(), out decimal birikenTutar) || birikenTutar < 0)
            {
                MessageBox.Show("Lütfen geçerli hedef bilgileri ve tutarları giriniz.", "Hatalı Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Hedef guncelHedef = new Hedef
                {
                    HedefID = seciliHedefId,
                    KullaniciID = FormGiris.AktifKullanici.KullaniciID,
                    HedefAdi = txtHedefAdi.Text.Trim(),
                    HedefTutar = hedefTutar,
                    BirikenTutar = birikenTutar,
                    HedefTarih = dtpHedefTarih.Value
                };

                if (hedefController.HedefGuncelle(guncelHedef))
                {
                    MessageBox.Show("Hedef ve birikim durumu güncellendi!", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AlanlariTemizle();
                    ListeyiYenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHedefSil_Click(object sender, EventArgs e)
        {
            if (seciliHedefId == 0)
            {
                MessageBox.Show("Lütfen tablodan silmek istediğiniz hedefi seçiniz.", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show("Seçili hedef kaydını kalıcı olarak silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    if (hedefController.HedefSil(seciliHedefId, FormGiris.AktifKullanici.KullaniciID))
                    {
                        MessageBox.Show("Hedef kaydı silindi.", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AlanlariTemizle();
                        ListeyiYenile();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHedefTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnAnaSayfaDon_Click(object sender, EventArgs e)
        {
            FormAna ana = new FormAna();
            ana.Show();
            this.Hide();
        }
    }
}
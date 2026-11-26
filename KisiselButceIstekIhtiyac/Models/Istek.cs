using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselButceIstekIhtiyac.Models
{
    public class Istek
    {
        public int IstekID { get; set; }
        public int KullaniciID { get; set; }
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public decimal EmekKarsiligiSaat { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime KarantinaBitisTarihi { get; set; }
        public string Durum { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselButceIstekIhtiyac.Models
{
    public class Gider
    {
        public int GiderID { get; set; }
        public int KullaniciID { get; set; }
        public string GiderAdi { get; set; }
        public string GiderTuru { get; set; }
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
    }
}
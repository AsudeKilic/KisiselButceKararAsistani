using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselButceIstekIhtiyac.Models
{
    public class Hedef
    {
        public int HedefID { get; set; }
        public int KullaniciID { get; set; }
        public string HedefAdi { get; set; }
        public decimal HedefTutar { get; set; }
        public decimal BirikenTutar { get; set; }
        public DateTime HedefTarih { get; set; }
        public string Durum { get; set; }
    }
}
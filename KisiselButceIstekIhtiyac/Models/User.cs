using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselButceIstekIhtiyac.Models
{
    public class User
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public decimal AylikNetMaas { get; set; }
        public decimal GunlukCalismaSaati { get; set; }
        public decimal SaatlikKazanc { get; set; }
        public string Rol { get; set; }
    }
}

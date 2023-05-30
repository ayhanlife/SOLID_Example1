using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.Concrate
{
    public class Kullanici : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public string Role { get; set; }
    }
}

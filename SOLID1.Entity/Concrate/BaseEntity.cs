using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.Concrate
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime GuncellemeTarih { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}

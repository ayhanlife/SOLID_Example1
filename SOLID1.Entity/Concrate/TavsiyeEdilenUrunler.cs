using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.Concrate
{
    public class TavsiyeEdilenUrunler : BaseEntity
    {
        public virtual List<Stok>? Stok { get; set; }
    }
}

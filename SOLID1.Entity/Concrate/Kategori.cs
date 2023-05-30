using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.Concrate
{
    public class Kategori : BaseEntity
    {
        public string Adi { get; set; }
        public List<Stok> Stok { get; set; }

    }
}

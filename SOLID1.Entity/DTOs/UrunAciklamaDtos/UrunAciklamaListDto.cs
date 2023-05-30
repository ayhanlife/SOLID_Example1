using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID1.Entity.DTOs.UrunAciklamaDtos
{
    public class UrunAciklamaListDto
    {
        public int Id { get; set; }
        public string? Brim { get; set; }
        public float? Tutar { get; set; }
        public string? Aciklama { get; set; }
    }
}

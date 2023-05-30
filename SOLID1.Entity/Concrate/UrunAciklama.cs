namespace SOLID1.Entity.Concrate
{
    public class UrunAciklama:BaseEntity
    {
        //public int Id { get; set; }
        public string? Brim { get; set; }
        public float? Tutar { get; set; }
        public string? Aciklama { get; set; }
        //public int? StokId { get; set; }
        public virtual List<Stok>? Stok { get; set; }

    }
}

namespace HastaneRandevuSistemi.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public int HastaId { get; set; }
        public DateTime RandevuSaati { get; set; }
        public string DoktorAdi { get; set; }
        public int DoktorId { get; set; }
    }
}

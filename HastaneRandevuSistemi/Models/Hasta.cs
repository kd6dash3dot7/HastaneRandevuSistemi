using Microsoft.AspNetCore.Identity;

namespace HastaneRandevuSistemi.Models
{
    public class Hasta : IdentityUser 
    {
        public int Id { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string HastaEmail{ get; set; }
        public string Password { get; set; }
    }
}

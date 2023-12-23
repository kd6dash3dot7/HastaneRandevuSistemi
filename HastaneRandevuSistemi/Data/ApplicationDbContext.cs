using HastaneRandevuSistemi.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Doktor> Doktorlar { get; set; } 
        public DbSet <Hasta> Hastalar { get; set; }
        public DbSet<Poliklinik> Poliklinikler { get; set; }
        public DbSet<Services> Hizmetler { get; set; }
        public DbSet<AnaBilimDali> AnaBilimDallari { get; set; }
        public DbSet<Randevu> Randevular {  get; set; }


    }
}

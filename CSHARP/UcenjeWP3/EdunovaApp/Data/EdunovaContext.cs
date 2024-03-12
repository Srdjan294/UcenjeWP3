using EdunovaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaApp.Data
{
    public class EdunovaContext:DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> options)
            : base(options) { 
        
        }

        public DbSet<Smjer> Smjerovi { get; set; }
    }
}

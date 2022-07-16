using Microsoft.EntityFrameworkCore;

namespace AspDotNetLab4.Models
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { set; get; }
        public DbSet<Album> Albums { set; get; }

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

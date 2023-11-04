using Microsoft.EntityFrameworkCore;
using SimpleRestv2.Models;

namespace SimpleRestv2.Context
{
    public class CyberarkDbContext : DbContext
    {
        public CyberarkDbContext(DbContextOptions<CyberarkDbContext> options) : base(options)
        {
        }

        public DbSet<Cyberark> Cyberarks { get; set; }
    }
}

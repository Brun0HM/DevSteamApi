using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevSteamAPI.Data
{
    public class DevSteamAPIContext : IdentityDbContext
    {
        // Método construtor
        public DevSteamAPIContext(DbContextOptions<DevSteamAPIContext> options)
            : base(options)
        {
        }

        //Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

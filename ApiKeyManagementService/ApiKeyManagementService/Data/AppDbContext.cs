using ApiKeyManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiKeyManagementService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ApiKey> ApiKeys { get; set; }
        public DbSet<IpAllowList> IpAllowLists { get; set; }
        public DbSet<IpBlockList> IpBlockLists { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RateLimit> RateLimits { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

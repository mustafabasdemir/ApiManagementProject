using ApiKeyManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiKeyManagementService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<ApiKey> ApiKeys { get; set; }
        public DbSet<ApiPermission> ApiPermissions { get; set; }
        public DbSet<ApiUsageLog> ApiUsageLogs { get; set; }
    }
}

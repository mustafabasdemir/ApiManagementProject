using System.Security;

namespace ApiKeyManagementService.Models
{
    public class ApiKey
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Key { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; } = true;

        public User User { get; set; }
        public List<Permission> Permissions { get; set; } = new();
        public List<IpAllowList> IpAllowLists { get; set; } = new();
    }
}

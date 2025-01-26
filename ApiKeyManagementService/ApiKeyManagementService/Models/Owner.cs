using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace ApiKeyManagementService.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } // Kullanıcı veya servis adı
        public string Type { get; set; } // Kullanıcı mı, servis mi?
        public ICollection<ApiKey> ApiKeys { get; set; }
    }
}

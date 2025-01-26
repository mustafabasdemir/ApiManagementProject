using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace ApiKeyManagementService.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Mail { get; set; } 
        public string Type { get; set; } 

    }
}

using System.Security;

namespace ApiKeyManagementService.Models
{
    public class ApiKey
    {
        public int Id { get; set; }
        public string Key { get; set; } // api key
        public int OwnerId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}

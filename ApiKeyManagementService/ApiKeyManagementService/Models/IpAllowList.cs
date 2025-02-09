namespace ApiKeyManagementService.Models
{
    public class IpAllowList
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ApiKey ApiKey { get; set; }
    }
}

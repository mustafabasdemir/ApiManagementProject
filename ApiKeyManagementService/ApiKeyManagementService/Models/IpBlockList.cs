namespace ApiKeyManagementService.Models
{
    public class IpBlockList
    {
        public int Id { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }

}

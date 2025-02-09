namespace ApiKeyManagementService.Models
{
    public class RateLimit
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public int DailyLimit { get; set; }
        public int Used { get; set; } = 0;

        public ApiKey ApiKey { get; set; }
    }
}

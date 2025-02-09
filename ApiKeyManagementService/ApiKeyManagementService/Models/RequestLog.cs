namespace ApiKeyManagementService.Models
{
    public class RequestLog
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public string RequestUrl { get; set; } = string.Empty;
        public string HttpMethod { get; set; } = string.Empty;
        public int ResponseCode { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public ApiKey ApiKey { get; set; }
    }
}

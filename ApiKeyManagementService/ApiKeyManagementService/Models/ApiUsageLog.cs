namespace ApiKeyManagementService.Models
{
    public class ApiUsageLog
    {
        public int Id { get; set; }
        public string ApiKey { get; set; } 
        public string Endpoint { get; set; }
        public string Action { get; set; } 
        public DateTime RequestDate { get; set; } 
        public bool Success { get; set; } 
        public string ErrorMessage { get; set; } 
    }
}

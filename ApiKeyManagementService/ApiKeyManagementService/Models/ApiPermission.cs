namespace ApiKeyManagementService.Models
{
    public class ApiPermission
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public ApiKey ApiKey { get; set; }
        public string Endpoint { get; set; } //dıs servisin gidecegi api
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public bool CanDelete { get; set; }
        public bool CanUpdate { get; set; }
        public int DailyReadLimit { get; set; }
        public int DailyWriteLimit { get; set; }
        public int DailyDeleteLimit { get; set; }
        public int DailyUpdateLimit { get; set; }
    }
}

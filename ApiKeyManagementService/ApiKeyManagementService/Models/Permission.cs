namespace ApiKeyManagementService.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public int ApiKeyId { get; set; }
        public string PermissionType { get; set; } = string.Empty; // Read, Write, Delete, Update

        public ApiKey ApiKey { get; set; }
    }

}

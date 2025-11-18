namespace TuitionSaaS.Core.Entities;

public class User
{
    public Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }

    public Guid TenantId { get; set; } // Belongs to which Tenant
}
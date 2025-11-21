namespace TuitionSaaS.Core.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = null!;  // required
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public Guid TenantId { get; set; }

    // Add FullName property
    public string FullName { get; set; } = null!;
}
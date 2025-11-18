namespace TuitionSaaS.Core.Entities;

public class Class
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public Guid TeacherId { get; set; }
    public Guid TenantId { get; set; }
}
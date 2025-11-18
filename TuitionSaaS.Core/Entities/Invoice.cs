namespace TuitionSaaS.Core.Entities;

public class Invoice
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public DateTime IssuedAt { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
}
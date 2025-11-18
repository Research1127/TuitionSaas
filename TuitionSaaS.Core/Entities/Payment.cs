namespace TuitionSaaS.Core.Entities;

public class Payment
{
    public Guid Id { get; set; }
    public Guid InvoiceId { get; set; }
    public DateTime PaidAt { get; set; }
    public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; }
}
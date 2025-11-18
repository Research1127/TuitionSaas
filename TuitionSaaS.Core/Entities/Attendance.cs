namespace TuitionSaaS.Core.Entities;

public class Attendance
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid ClassId { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
}
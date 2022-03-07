namespace Cahsul.Domain.Entities;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Salary { get; set; }
}

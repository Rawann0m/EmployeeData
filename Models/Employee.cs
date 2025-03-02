using System.ComponentModel.DataAnnotations;
namespace EmployeeData.Models{
public class Employee
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; }

    [Required,StringLength(50)]
    public string Position { get; set; }

    [Range(0, double.MaxValue)]
    public decimal Salary { get; set; }
}
}
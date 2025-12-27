using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Person
{
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [MaxLength(30, ErrorMessage = "First name cannot exceed 30 characters")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last name is required")]
    [MaxLength(30, ErrorMessage = "Last name cannot exceed 30 characters")]
    public string LastName { get; set; } = string.Empty;
}


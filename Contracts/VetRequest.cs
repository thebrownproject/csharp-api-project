using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class VetRequest
{
    [Required]
    [AllowedValues(["Veterinary Doctor", "Veterinary Nurse", "Veterinary Technician", "Veterinary Assistant"])]
    public required string Title { get; set; }
    [Required]
    public required string FirstName { get; set; }
    [Required]
    public required string LastName { get; set; }
    public string? Email { get; set; }
    [Required]
    public required string Phone { get; set; }
    public string? ClinicName { get; set; }
    public string? ClinicAddress { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
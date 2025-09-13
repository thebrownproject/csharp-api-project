using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class AdopterRequest
{
    [Required]
    public required string FirstName { get; set; }
    [Required]
    public required string LastName { get; set; }
    public string? Email { get; set; }
    [Required]
    public required string Phone { get; set; }
    public string? AddressLine1 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public int? HouseholdSize { get; set; }
    public bool HasOtherPets { get; set; }
    [AllowedValues(["Potential", "Approved", "Rejected", "Blacklisted"])]
    public string AdoptionStatus { get; set; } = "Potential";
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

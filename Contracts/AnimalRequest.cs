using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class AnimalRequest
{
    [Required]
    public required string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Required]
    public required string Species { get; set; }
    public string Breed { get; set; }
    public string FurColour { get; set; }
    public decimal WeightKg { get; set; }
    [Required]
    public required DateTime ArrivalDate { get; set; }
    public bool Neutered { get; set; }
    [AllowedValues(["Available", "Pending", "Adopted", "Hold", "Medical Hold", "Not Available"])]
    public required string AdoptionStatus { get; set; }
    public Guid? BondedWith { get; set; }
    public string? RfidTag { get; set; }
    public string SpecialNeeds { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}
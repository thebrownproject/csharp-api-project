using min_api_project.Contracts;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Supabase_Minimal_API.Models;

[Table("animal")]
public class AnimalModel : BaseModel
{
    public AnimalModel() {
        Name = string.Empty;
        DateOfBirth = DateTime.MinValue;
        Species = string.Empty;
        Breed = string.Empty;
        FurColour = string.Empty;
        WeightKg = 0;
        ArrivalDate = DateTime.MinValue;
        Neutered = false;
        AdoptionStatus = string.Empty;
        BondedWith = Guid.Empty;
        RfidTag = string.Empty;
        SpecialNeeds = string.Empty;
        Description = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }
    public AnimalModel(Guid id, AnimalRequest request)
    {
        Id = id;
        Name = request.Name;
        DateOfBirth = request.DateOfBirth ?? DateTime.MinValue;
        Species = request.Species;
        Breed = request.Breed;
        FurColour = request.FurColour;
        WeightKg = request.WeightKg ?? 0;
        ArrivalDate = request.ArrivalDate;
        Neutered = request.Neutered;
        AdoptionStatus = request.AdoptionStatus;
        BondedWith = request.BondedWith;
        RfidTag = request.RfidTag;
        SpecialNeeds = request.SpecialNeeds;
        Description = request.Description;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("date_of_birth")]
    public DateTime DateOfBirth { get; set; }

    [Column("species")]
    public string Species { get; set; }

    [Column("breed")]
    public string Breed { get; set; }

    [Column("fur_colour")]
    public string FurColour { get; set; }

    [Column("weight_kg")]
    public decimal WeightKg { get; set; }

    [Column("arrival_date")]
    public DateTime ArrivalDate { get; set; }

    [Column("neutered")]
    public bool Neutered { get; set; }

    [Column("adoption_status")]
    public string AdoptionStatus { get; set; }

    [Column("bonded_with")]
    public Guid? BondedWith { get; set; }

    [Column("rfid_tag")]
    public string? RfidTag { get; set; }

    [Column("special_needs")]
    public string SpecialNeeds { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
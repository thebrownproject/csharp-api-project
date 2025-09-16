using min_api_project.Contracts;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("animal")]
public class AnimalModel : BaseModel
{
    public AnimalModel()
    {
        Name = string.Empty;
        DateOfBirth = null;
        Species = string.Empty;
        Breed = string.Empty;
        FurColour = string.Empty;
        WeightKg = 0;
        ArrivalDate = DateOnly.MinValue;
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
        DateOfBirth = request.DateOfBirth.HasValue ? DateOnly.FromDateTime(request.DateOfBirth.Value) : null;
        Species = request.Species;
        Breed = request.Breed;
        FurColour = request.FurColour;
        WeightKg = request.WeightKg ?? 0;
        ArrivalDate = DateOnly.FromDateTime(request.ArrivalDate);
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

    [Supabase.Postgrest.Attributes.Column("name")]
    public string Name { get; set; }

    [Supabase.Postgrest.Attributes.Column("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [Supabase.Postgrest.Attributes.Column("species")]
    public string Species { get; set; }

    [Supabase.Postgrest.Attributes.Column("breed")]
    public string? Breed { get; set; }

    [Supabase.Postgrest.Attributes.Column("fur_colour")]
    public string? FurColour { get; set; }

    [Supabase.Postgrest.Attributes.Column("weight_kg")]
    public decimal? WeightKg { get; set; }

    [Supabase.Postgrest.Attributes.Column("arrival_date")]
    public DateOnly ArrivalDate { get; set; }

    [Supabase.Postgrest.Attributes.Column("neutered")]
    public bool Neutered { get; set; }

    [Supabase.Postgrest.Attributes.Column("adoption_status")]
    public string AdoptionStatus { get; set; }

    [ForeignKey("bonded_with")]
    [Supabase.Postgrest.Attributes.Column("bonded_with")]
    public Guid? BondedWith { get; set; }

    [Supabase.Postgrest.Attributes.Column("rfid_tag")]
    public string? RfidTag { get; set; }

    [Supabase.Postgrest.Attributes.Column("special_needs")]
    public string? SpecialNeeds { get; set; }

    [Supabase.Postgrest.Attributes.Column("description")]
    public string? Description { get; set; }

    [Supabase.Postgrest.Attributes.Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Supabase.Postgrest.Attributes.Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
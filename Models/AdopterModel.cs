using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;
namespace min_api_project.Models;


// Selects the adopters table from the database
[Supabase.Postgrest.Attributes.Table("adopter")]
// New class for the adopter model inheriting from the BaseModel
// BaseModel is a class from the Supabase.Postgrest.Models namespace
public class AdopterModel : BaseModel
{
    // Constructor for the AdopterModel
    public AdopterModel()
    {
        Id = Guid.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        AddressLine1 = string.Empty;
        City = string.Empty;
        State = string.Empty;
        PostalCode = string.Empty;
        DateOfBirth = null;
        HouseholdSize = null;
        HasOtherPets = false;
        AdoptionStatus = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }

    // Constructor for the ActiveVolunteersModel with request parameters
    public AdopterModel(Guid id, AdopterRequest request)
    {
        Id = id;
        FirstName = request.FirstName;
        LastName = request.LastName;
        Email = request.Email;
        Phone = request.Phone;
        AddressLine1 = request.AddressLine1;
        City = request.City;
        State = request.State;
        PostalCode = request.PostalCode;
        DateOfBirth = request.DateOfBirth is DateTime date ? DateOnly.FromDateTime(date) : null;
        HouseholdSize = request.HouseholdSize ?? 0;
        HasOtherPets = request.HasOtherPets;
        AdoptionStatus = request.AdoptionStatus;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Supabase.Postgrest.Attributes.Column("first_name")]
    public string FirstName { get; set; }

    [Supabase.Postgrest.Attributes.Column("last_name")]
    public string LastName { get; set; }

    [Supabase.Postgrest.Attributes.Column("email")]
    public string? Email { get; set; }

    [Supabase.Postgrest.Attributes.Column("phone")]
    public string Phone { get; set; }

    [Supabase.Postgrest.Attributes.Column("address_line_1")]
    public string? AddressLine1 { get; set; }

    [Supabase.Postgrest.Attributes.Column("city")]
    public string? City { get; set; }

    [Supabase.Postgrest.Attributes.Column("state")]
    public string? State { get; set; }

    [Supabase.Postgrest.Attributes.Column("postal_code")]
    public string? PostalCode { get; set; }

    [Supabase.Postgrest.Attributes.Column("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [Supabase.Postgrest.Attributes.Column("household_size")]
    public int? HouseholdSize { get; set; }

    [Supabase.Postgrest.Attributes.Column("has_other_pets")]
    public bool HasOtherPets { get; set; }

    [Supabase.Postgrest.Attributes.Column("adoption_status")]
    public string AdoptionStatus { get; set; }

    [Supabase.Postgrest.Attributes.Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Supabase.Postgrest.Attributes.Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
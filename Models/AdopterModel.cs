using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace Supabase_Minimal_API.Models;


// Selects the adopters table from the database
[Table("adopter")]
// New class for the adopter model inheriting from the BaseModel
// BaseModel is a class from the Supabase.Postgrest.Models namespace
public class AdopterModel : BaseModel
{
    // Constructor for the AdopterModel
    public AdopterModel() {
        Id = Guid.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        AddressLine1 = string.Empty;
        City = string.Empty;
        State = string.Empty;
        PostalCode = string.Empty;
        DateOfBirth = DateTime.MinValue;
        HouseholdSize = 0;
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
        DateOfBirth = request.DateOfBirth ?? DateTime.MinValue;
        HouseholdSize = request.HouseholdSize ?? 0;
        HasOtherPets = request.HasOtherPets;
        AdoptionStatus = request.AdoptionStatus;
        CreatedAt = request.CreatedAt;
        UpdatedAt = request.UpdatedAt;
    }

[PrimaryKey("id")]
public Guid Id { get; set; }

[Column("first_name")]
public string FirstName { get; set; }

[Column("last_name")]
public string LastName { get; set; }

[Column("email")]
public string Email { get; set; }

[Column("phone")]
public string Phone { get; set; }

[Column("address_line_1")]
public string AddressLine1 { get; set; }

[Column("city")]
public string City { get; set; }

[Column("state")]
public string State { get; set; }

[Column("postal_code")]
public string PostalCode { get; set; }

[Column("date_of_birth")]
public DateTime DateOfBirth { get; set; }

[Column("household_size")]
public int HouseholdSize { get; set; }

[Column("has_other_pets")]
public bool HasOtherPets { get; set; }

[Column("adoption_status")]
public string AdoptionStatus { get; set; }

[Column("created_at")]
public DateTime CreatedAt { get; set; }

[Column("updated_at")]
public DateTime UpdatedAt { get; set; }
}
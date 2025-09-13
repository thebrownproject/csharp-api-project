// Controller for managing vet contacts
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace Supabase_Minimal_API.Models;

[Table("vet")]
public class VetModel : BaseModel
{

    public VetModel() {
        Id = Guid.Empty;
        Title = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Phone = string.Empty;
        ClinicName = string.Empty;
        ClinicAddress = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }
    public VetModel(Guid id, VetRequest request)
    {
        Id = id;
        Title = request.Title;
        FirstName = request.FirstName;
        LastName = request.LastName;
        Email = request.Email;
        Phone = request.Phone;
        ClinicName = request.ClinicName;
        ClinicAddress = request.ClinicAddress;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    public string Phone { get; set; }

    [Column("clinic_name")]
    public string? ClinicName { get; set; }

    [Column("clinic_address")]
    public string? ClinicAddress { get; set; }

    [Column("created_at")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}
// Controller for managing vet contacts
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("vet")]
public class VetModel : BaseModel
{

    public VetModel()
    {
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

    [Supabase.Postgrest.Attributes.Column("title")]
    public string Title { get; set; }

    [Supabase.Postgrest.Attributes.Column("first_name")]
    public string FirstName { get; set; }

    [Supabase.Postgrest.Attributes.Column("last_name")]
    public string LastName { get; set; }

    [Supabase.Postgrest.Attributes.Column("email")]
    public string? Email { get; set; }

    [Supabase.Postgrest.Attributes.Column("phone")]
    public string Phone { get; set; }

    [Supabase.Postgrest.Attributes.Column("clinic_name")]
    public string? ClinicName { get; set; }

    [Supabase.Postgrest.Attributes.Column("clinic_address")]
    public string? ClinicAddress { get; set; }

    [Supabase.Postgrest.Attributes.Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Supabase.Postgrest.Attributes.Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
// Controller for managing vet contacts
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Supabase_Minimal_API.Models;

[Table("vet")]
public class VetModel : BaseModel
{
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
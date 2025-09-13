using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace Supabase_Minimal_API.Models;


[Table("adoption")]
public class AdoptionModel : BaseModel
{
    // Constructor for the AdoptionModel
    public AdoptionModel() {
        Id = Guid.Empty;
        AnimalId = Guid.Empty;
        AdopterId = Guid.Empty;
        AdoptionDate = DateTime.MinValue;
        AdoptionFee = 0;
        ReturnDate = null;
        ReturnReason = string.Empty;
        AdoptionStatus = string.Empty;
        Notes = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }


    public AdoptionModel(Guid id, AdoptionRequest request)
    {
        Id = id;
        AnimalId = request.AnimalId;
        AdopterId = request.AdopterId;
        AdoptionDate = request.AdoptionDate;
        AdoptionFee = request.AdoptionFee;
        ReturnDate = request.ReturnDate;
        ReturnReason = request.ReturnReason;
        AdoptionStatus = request.AdoptionStatus;
        Notes = request.Notes;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("animal_id")]
    public Guid AnimalId { get; set; }

    [Column("adopter_id")]
    public Guid AdopterId { get; set; }

    [Column("adoption_date")]
    public DateTime AdoptionDate { get; set; }

    [Column("adoption_fee")]
    public decimal AdoptionFee { get; set; }

    [Column("return_date")]
    public DateTime? ReturnDate { get; set; }

    [Column("return_reason")]
    public string? ReturnReason { get; set; }

    [Column("adoption_status")]
    public string AdoptionStatus { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}


// CREATE TABLE adoption (
//     id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
//     animal_id UUID NOT NULL REFERENCES animal(id) ON DELETE RESTRICT,
//     adopter_id UUID NOT NULL REFERENCES adopter(id) ON DELETE RESTRICT,
//     adoption_date DATE NOT NULL DEFAULT CURRENT_DATE,
//     adoption_fee DECIMAL(8,2) NOT NULL,
//     return_date DATE,
//     return_reason TEXT,
//     adoption_status VARCHAR(20) DEFAULT 'Active' CHECK (adoption_status IN ('Active', 'Returned', 'Cancelled')),
//     notes TEXT,
//     created_at TIMESTAMP DEFAULT NOW(),
//     updated_at TIMESTAMP DEFAULT NOW()
// );
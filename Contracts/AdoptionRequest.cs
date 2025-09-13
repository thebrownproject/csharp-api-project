using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class AdoptionRequest
{
    [Required]
    public required Guid AnimalId { get; set; }
    [Required]
    public required Guid AdopterId { get; set; }
    [Required]
    public required DateTime AdoptionDate { get; set; }
    [Required]
    public required decimal AdoptionFee { get; set; }
    public DateTime ReturnDate { get; set; }
    public string? ReturnReason { get; set; }
    [AllowedValues(["Active", "Returned", "Cancelled"])]
    public required string AdoptionStatus { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
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
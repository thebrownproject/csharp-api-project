using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class ShiftTypeRequest
{
    [Required]
    public required string TypeName { get; set; }
    [Required]
    public required TimeOnly DefaultStart { get; set; }
    [Required]
    public required TimeOnly DefaultEnd { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; } = true;
}

// CREATE TABLE shift_type (
//     type_name VARCHAR(50) PRIMARY KEY,
//     default_start TIME NOT NULL,
//     default_end TIME NOT NULL,
//     description TEXT,
//     is_active BOOLEAN DEFAULT TRUE
// );
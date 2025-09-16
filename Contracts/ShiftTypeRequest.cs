using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class ShiftTypeRequest
{
    [Required]
    public required string TypeName { get; set; }
    [Required]
    [RegularExpression(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$", ErrorMessage = "Time must be in HH:MM:SS format")]
    public required TimeSpan DefaultStart { get; set; } = new TimeSpan(0, 0, 0);
    [Required]
    [RegularExpression(@"^([0-1]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$", ErrorMessage = "Time must be in HH:MM:SS format")]
    public required TimeSpan DefaultEnd { get; set; } = new TimeSpan(0, 0, 0);
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
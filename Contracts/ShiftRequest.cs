using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class ShiftRequest
{
    [Required]
    public required Guid UserId { get; set; }
    [AllowedValues(["Morning", "Afternoon", "Evening", "Night"])]
    [Required]
    public required string ShiftType { get; set; }
    [Required]
    public required DateTime ShiftDate { get; set; }
    public TimeSpan? ActualStart { get; set; } = new TimeSpan(0, 0, 0);
    public TimeSpan? ActualEnd { get; set; } = new TimeSpan(0, 0, 0);
    public string? PrimaryRole { get; set; }
    public string[]? DutiesPerformed { get; set; }
    [AllowedValues(["Scheduled", "In Progress", "Completed", "No Show", "Cancelled"])]
    public string Status { get; set; } = "Scheduled";
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}

// CREATE TABLE shift (
//     shift_id SERIAL PRIMARY KEY,
//     user_id UUID NOT NULL REFERENCES "user"(id) ON DELETE CASCADE,
//     shift_type VARCHAR(50) NOT NULL REFERENCES shift_type(type_name),
//     shift_date DATE NOT NULL,
//     actual_start TIME,
//     actual_end TIME,
//     primary_role VARCHAR(100),
//     duties_performed TEXT[],
//     status VARCHAR(20) DEFAULT 'Scheduled' CHECK (status IN ('Scheduled', 'In Progress', 'Completed', 'No Show', 'Cancelled')),
//     notes TEXT,
//     created_at TIMESTAMP DEFAULT NOW(),
//     updated_at TIMESTAMP DEFAULT NOW(),

//     -- Prevent double-booking
//     UNIQUE(user_id, shift_date, shift_type)
// );
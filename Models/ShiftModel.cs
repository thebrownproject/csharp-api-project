using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace min_api_project.Models;

[Table("shift")]
public class ShiftModel : BaseModel
{
    public ShiftModel() {
        ShiftId = 0;
        UserId = Guid.Empty;
        ShiftType = string.Empty;
        ShiftDate = DateOnly.MinValue;
        ActualStart = null;
        ActualEnd = null;
        PrimaryRole = string.Empty;
        DutiesPerformed = [string.Empty];
        Status = string.Empty;
        Notes = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }
    public ShiftModel(int shiftId, ShiftRequest request)
    {
        ShiftId = shiftId;
        UserId = request.UserId;
        ShiftType = request.ShiftType;
        ShiftDate = DateOnly.FromDateTime(request.ShiftDate);
        ActualStart = request.ActualStart;
        ActualEnd = request.ActualEnd;
        PrimaryRole = request.PrimaryRole;
        DutiesPerformed = request.DutiesPerformed;
        Status = request.Status;
        Notes = request.Notes;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("shift_id")]
    public int ShiftId { get; set; }
    
    [Column("user_id")]
    public Guid UserId { get; set; }
    
    [Column("shift_type")]
    public string ShiftType { get; set; }
    
    [Column("shift_date")]
    public DateOnly ShiftDate { get; set; }
    
    [Column("actual_start")]
    public TimeOnly? ActualStart { get; set; }
    
    [Column("actual_end")]
    public TimeOnly? ActualEnd { get; set; }
    
    [Column("primary_role")]
    public string? PrimaryRole { get; set; }
    
    [Column("duties_performed")]
    public string[]? DutiesPerformed { get; set; }
    
    [Column("status")]
    public string Status { get; set; }
    
    [Column("notes")]
    public string? Notes { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
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
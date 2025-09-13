using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class RfidLogRequest
{
    public DateTime? ScanTime { get; set; }
    public Guid? UserId { get; set; }
    public Guid? AnimalId { get; set; }
    [Required]
    public required string RfidTag { get; set; }
    public Guid? AnimalNote { get; set; }
}

// CREATE TABLE rfid_log (
//     id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
//     scan_time TIMESTAMP DEFAULT NOW() NOT NULL,
//     user_id UUID REFERENCES "user"(id),     -- User who scanned (volunteer)
//     animal_id UUID REFERENCES animal(id),   -- Animal that was scanned
//     rfid_tag VARCHAR(50),
//     animal_note UUID REFERENCES animal_note(id) ON DELETE SET NULL -- Note associated with the scan
// );
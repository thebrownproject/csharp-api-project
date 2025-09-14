using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace Supabase_Minimal_API.Models;

[Table("rfid_log")]
public class RfidLogTableModel : BaseModel
{
    public RfidLogTableModel() {
        Id = Guid.Empty;
        ScanTime = DateTime.MinValue;
        UserId = Guid.Empty;
        AnimalId = Guid.Empty;
        RfidTag = string.Empty;
        AnimalNote = Guid.Empty;
    }

    public RfidLogTableModel(Guid id, RfidLogRequest request)
    {
        Id = id;
        ScanTime = request.ScanTime;
        UserId = request.UserId;
        AnimalId = request.AnimalId;
        RfidTag = request.RfidTag;
        AnimalNote = request.AnimalNote;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }
    
    [Column("scan_time")]
    public DateTime? ScanTime { get; set; }
    
    [Column("user_id")]
    public Guid? UserId { get; set; }
    
    [Column("animal_id")]
    public Guid? AnimalId { get; set; }
    
    [Column("rfid_tag")]
    public string? RfidTag { get; set; }
    
    [Column("animal_note")]
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
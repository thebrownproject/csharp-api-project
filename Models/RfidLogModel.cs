using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("rfid_log")]
public class RfidLogModel : BaseModel
{
    public RfidLogModel()
    {
        Id = Guid.Empty;
        ScanTime = DateTime.UtcNow;
        UserId = Guid.Empty;
        AnimalId = Guid.Empty;
        RfidTag = string.Empty;
        AnimalNote = Guid.Empty;
    }

    public RfidLogModel(Guid id, RfidLogRequest request)
    {
        Id = id;
        ScanTime = request.ScanTime ?? DateTime.UtcNow;
        UserId = request.UserId;
        AnimalId = request.AnimalId;
        RfidTag = request.RfidTag;
        AnimalNote = request.AnimalNote;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Supabase.Postgrest.Attributes.Column("scan_time")]
    public DateTime ScanTime { get; set; }

    [ForeignKey("user_id")]
    [Supabase.Postgrest.Attributes.Column("user_id")]
    public Guid? UserId { get; set; }

    [ForeignKey("animal_id")]
    [Supabase.Postgrest.Attributes.Column("animal_id")]
    public Guid? AnimalId { get; set; }

    [Supabase.Postgrest.Attributes.Column("rfid_tag")]
    public string? RfidTag { get; set; }

    [ForeignKey("animal_note")]
    [Supabase.Postgrest.Attributes.Column("animal_note")]
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
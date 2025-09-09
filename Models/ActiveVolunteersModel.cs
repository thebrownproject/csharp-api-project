using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Supabase_Minimal_API.Models;


// Selects the active volunteers table from the database
[Table("active_volunteers")]
// New class for the active volunteers model inheriting from the BaseModel
// BaseModel is a class from the Supabase.Postgrest.Models namespace
public class ActiveVolunteersModel : BaseModel
{
    // Constructor for the ActiveVolunteersModel
    public ActiveVolunteersModel() {
        Id = Guid.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Phone = string.Empty;
        RFIDTag = string.Empty;
        VolunteerStartDate = string.Empty;
        VolunteerEndDate = string.Empty;
        VolunteerNotes = string.Empty;
    }

    // Constructor for the ActiveVolunteersModel with request parameters
    public ActiveVolunteersModel(Guid id, ActiveVolunteersRequest request)
    {
        Id = id;
        FirstName = request.FirstName;
        LastName = request.LastName;
        Phone = request.Phone;
        RFIDTag = request.RFIDTag;
        VolunteerStartDate = request.VolunteerStartDate;
        VolunteerEndDate = request.VolunteerEndDate;
        VolunteerNotes = request.VolunteerNotes;
    }

[PrimaryKey("id")]
public Guid Id { get; set; }

[Column("first_name")]
public string FirstName { get; set; }

[Column("last_name")]
public string LastName { get; set; }

[Column("phone")]
public string Phone { get; set; }

[Column("rfid_tag")]
public string RFIDTag { get; set; }

[Column("volunteer_start_date")]
public string VolunteerStartDate { get; set; }

[Column("volunteer_end_date")]
public string VolunteerEndDate { get; set; }

[Column("volunteer_notes")]
public string VolunteerNotes { get; set; }
}
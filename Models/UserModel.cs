using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace min_api_project.Models;

[Table("user")]
public class UserModel : BaseModel
{
    public UserModel()
    {
        Id = Guid.Empty;
        Email = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Phone = string.Empty;
        DateOfBirth = DateOnly.MinValue;
        AddressLine = string.Empty;
        City = string.Empty;
        State = string.Empty;
        PostalCode = string.Empty;
        RfidTag = string.Empty;
        VolunteerStartDate = DateOnly.MinValue;
        VolunteerEndDate = DateOnly.MinValue;
        IsAdmin = false;
        IsActiveVolunteer = true;
        VolunteerNotes = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }

    public UserModel(Guid id, UserRequest request)
    {
        Id = id;
        Email = request.Email;
        FirstName = request.FirstName;
        LastName = request.LastName;
        Phone = request.Phone;
        DateOfBirth = request.DateOfBirth.HasValue ? DateOnly.FromDateTime(request.DateOfBirth.Value) : DateOnly.MinValue;
        AddressLine = request.AddressLine ?? string.Empty;
        City = request.City ?? string.Empty;
        State = request.State ?? string.Empty;
        PostalCode = request.PostalCode ?? string.Empty;
        RfidTag = request.RfidTag ?? string.Empty;
        VolunteerStartDate = request.VolunteerStartDate.HasValue ? DateOnly.FromDateTime(request.VolunteerStartDate.Value) : DateOnly.MinValue;
        VolunteerEndDate = request.VolunteerEndDate.HasValue ? DateOnly.FromDateTime(request.VolunteerEndDate.Value) : DateOnly.MinValue;
        IsAdmin = request.IsAdmin;
        IsActiveVolunteer = request.IsActiveVolunteer;
        VolunteerNotes = request.VolunteerNotes;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }

    [Column("phone")]
    public string? Phone { get; set; }

    [Column("date_of_birth")]
    public DateOnly DateOfBirth { get; set; }

    [Column("address_line")]
    public string AddressLine { get; set; }

    [Column("city")]
    public string City { get; set; }

    [Column("state")]
    public string State { get; set; }

    [Column("postal_code")]
    public string PostalCode { get; set; }

    [Column("rfid_tag")]
    public string RfidTag { get; set; }

    [Column("volunteer_start_date")]
    public DateOnly VolunteerStartDate { get; set; }

    [Column("volunteer_end_date")]
    public DateOnly VolunteerEndDate { get; set; }

    [Column("is_admin")]
    public bool IsAdmin { get; set; }

    [Column("is_active_volunteer")]
    public bool IsActiveVolunteer { get; set; }

    [Column("volunteer_notes")]
    public string? VolunteerNotes { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
}






// CREATE TABLE "user" (
//     id UUID PRIMARY KEY REFERENCES auth.users(id) ON DELETE CASCADE,
//     email VARCHAR(255) UNIQUE NOT NULL,
//     first_name VARCHAR(100),
//     last_name VARCHAR(100),
//     phone VARCHAR(20),
//     date_of_birth DATE,
//     address_line VARCHAR(255),
//     city VARCHAR(100),
//     state VARCHAR(50),
//     postal_code VARCHAR(20),
//     rfid_tag VARCHAR(50) UNIQUE,        -- For RFID access system

//     -- Volunteer-specific fields
//     volunteer_start_date DATE,          -- Date volunteer started
//     volunteer_end_date DATE,            -- Date volunteer stopped (NULL if active)
//     is_admin BOOLEAN DEFAULT FALSE, -- Whether user is a volunteer
//     is_active_volunteer BOOLEAN DEFAULT TRUE, -- Whether volunteer is currently active
//     volunteer_notes TEXT,               -- General notes about the volunteer

//     created_at TIMESTAMP DEFAULT NOW(),
//     updated_at TIMESTAMP DEFAULT NOW()
// );
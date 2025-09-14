using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class UserRequest
{
    [Required]
    public required string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string AddressLine { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string RfidTag { get; set; }
    public DateTime VolunteerStartDate { get; set; }
    public DateTime VolunteerEndDate { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsActiveVolunteer { get; set; }
    public string VolunteerNotes { get; set; }
    public DateTime CreatedAt { get; set; }
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
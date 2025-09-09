using Supabase_Minimal_API.Validation;

public class VetRequest
{
    [AllowedValues(["Veterinary Doctor", "Veterinary Nurse", "Veterinary Technician", "Veterinary Assistant"])]
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string ClinicName { get; set; }
    public string ClinicAddress { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
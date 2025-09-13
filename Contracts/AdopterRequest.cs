using System.ComponentModel.DataAnnotations;

public class AdopterRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int HouseholdSize { get; set; }
    public bool HasOtherPets { get; set; }
    public string AdoptionStatus { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

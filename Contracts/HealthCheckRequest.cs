using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class HealthCheckRequest
{
    [Required]
    public required Guid AnimalId { get; set; }
    [Required]
    public required Guid VetId { get; set; }
    public DateTime CheckDate { get; set; }
    public string CheckType { get; set; }
    public decimal WeightKg { get; set; }
    public decimal TemperatureCelsius { get; set; }
    public int HeartRate { get; set; }
    public string ExaminationNotes { get; set; }
    public string Diagnosis { get; set; }
    public string TreatmentGiven { get; set; }
    public string MedicationsPrescribed { get; set; }
    public bool FollowUpRequired { get; set; }
    public DateTime FollowUpDate { get; set; }
    public string OverallHealthStatus { get; set; }
    public DateTime CreatedAt { get; set; }
}

// CREATE TABLE health_check (
//     id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
//     animal_id UUID NOT NULL REFERENCES animal(id) ON DELETE CASCADE,
//     vet_id UUID NOT NULL REFERENCES vet(id) ON DELETE RESTRICT,
//     check_date DATE NOT NULL DEFAULT CURRENT_DATE,
//     check_type VARCHAR(50) NOT NULL,
//     weight_kg DECIMAL(5,2),
//     temperature_celsius DECIMAL(4,1),
//     heart_rate INTEGER,
//     examination_notes TEXT,
//     diagnosis TEXT,
//     treatment_given TEXT,
//     medications_prescribed TEXT,
//     follow_up_required BOOLEAN DEFAULT FALSE,
//     follow_up_date DATE,
//     overall_health_status VARCHAR(20) DEFAULT 'Good' CHECK (overall_health_status IN ('Excellent', 'Good', 'Fair', 'Poor', 'Critical')),
//     created_at TIMESTAMP DEFAULT NOW()
// );
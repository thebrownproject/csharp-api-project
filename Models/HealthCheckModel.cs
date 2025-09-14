using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace min_api_project.Models;

[Table("health_check")]
public class HealthCheckModel : BaseModel
{
    public HealthCheckModel()
    {
        Id = Guid.Empty;
        AnimalId = Guid.Empty;
        VetId = Guid.Empty;
        CheckDate = DateOnly.MinValue;
        CheckType = string.Empty;
        WeightKg = null;
        TemperatureCelsius = null;
        HeartRate = null;
        ExaminationNotes = string.Empty;
        Diagnosis = string.Empty;
        TreatmentGiven = string.Empty;
        MedicationsPrescribed = string.Empty;
        FollowUpRequired = false;
        FollowUpDate = null;
        OverallHealthStatus = string.Empty;
        CreatedAt = DateTime.MinValue;
        UpdatedAt = DateTime.MinValue;
    }

    public HealthCheckModel(Guid id, HealthCheckRequest request)
    {
        Id = id;
        AnimalId = request.AnimalId;
        VetId = request.VetId;
        CheckDate = DateOnly.FromDateTime(request.CheckDate);
        CheckType = request.CheckType;
        WeightKg = request.WeightKg;
        TemperatureCelsius = request.TemperatureCelsius;
        HeartRate = request.HeartRate;
        ExaminationNotes = request.ExaminationNotes;
        Diagnosis = request.Diagnosis;
        TreatmentGiven = request.TreatmentGiven;
        MedicationsPrescribed = request.MedicationsPrescribed;
        FollowUpRequired = request.FollowUpRequired;
        FollowUpDate = request.FollowUpDate.HasValue ? DateOnly.FromDateTime(request.FollowUpDate.Value) : null;
        OverallHealthStatus = request.OverallHealthStatus;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("animal_id")]
    public Guid AnimalId { get; set; }

    [Column("vet_id")]
    public Guid VetId { get; set; }

    [Column("check_date")]
    public DateOnly CheckDate { get; set; }

    [Column("check_type")]
    public string CheckType { get; set; }

    [Column("weight_kg")]
    public decimal? WeightKg { get; set; }

    [Column("temperature_celsius")]
    public decimal? TemperatureCelsius { get; set; }

    [Column("heart_rate")]
    public int? HeartRate { get; set; }

    [Column("examination_notes")]
    public string? ExaminationNotes { get; set; }

    [Column("diagnosis")]
    public string? Diagnosis { get; set; }

    [Column("treatment_given")]
    public string? TreatmentGiven { get; set; }

    [Column("medications_prescribed")]
    public string? MedicationsPrescribed { get; set; }

    [Column("follow_up_required")]
    public bool FollowUpRequired { get; set; }

    [Column("follow_up_date")]
    public DateOnly? FollowUpDate { get; set; }

    [Column("overall_health_status")]
    public string OverallHealthStatus { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
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
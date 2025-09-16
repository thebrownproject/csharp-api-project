using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;
namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("health_check")]
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
    }

    public HealthCheckModel(Guid id, HealthCheckRequest request)
    {
        Id = id;
        AnimalId = request.AnimalId;
        VetId = request.VetId;
        CheckDate = request.CheckDate;
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
    }
    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [ForeignKey("animal_id")]
    [Supabase.Postgrest.Attributes.Column("animal_id")]
    public Guid AnimalId { get; set; }

    [ForeignKey("vet_id")]
    [Supabase.Postgrest.Attributes.Column("vet_id")]
    public Guid VetId { get; set; }

    [Supabase.Postgrest.Attributes.Column("check_date")]
    public DateOnly CheckDate { get; set; }

    [Supabase.Postgrest.Attributes.Column("check_type")]
    public string CheckType { get; set; }

    [Supabase.Postgrest.Attributes.Column("weight_kg")]
    public decimal? WeightKg { get; set; }

    [Supabase.Postgrest.Attributes.Column("temperature_celsius")]
    public decimal? TemperatureCelsius { get; set; }

    [Supabase.Postgrest.Attributes.Column("heart_rate")]
    public int? HeartRate { get; set; }

    [Supabase.Postgrest.Attributes.Column("examination_notes")]
    public string? ExaminationNotes { get; set; }

    [Supabase.Postgrest.Attributes.Column("diagnosis")]
    public string? Diagnosis { get; set; }

    [Supabase.Postgrest.Attributes.Column("treatment_given")]
    public string? TreatmentGiven { get; set; }

    [Supabase.Postgrest.Attributes.Column("medications_prescribed")]
    public string? MedicationsPrescribed { get; set; }

    [Supabase.Postgrest.Attributes.Column("follow_up_required")]
    public bool FollowUpRequired { get; set; }

    [Supabase.Postgrest.Attributes.Column("follow_up_date")]
    public DateOnly? FollowUpDate { get; set; }

    [Supabase.Postgrest.Attributes.Column("overall_health_status")]
    public string OverallHealthStatus { get; set; }

    [Supabase.Postgrest.Attributes.Column("created_at")]
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
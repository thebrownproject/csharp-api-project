using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Supabase_Minimal_API.Models;

[Table("health_check")]
class HealthCheckModel : BaseModel
{
    [PrimaryKey("id")]
    public required Guid Id { get; set; }

    // animal_id

    // vet_id

    // check_date

    // check_type

    // weight_kg

}
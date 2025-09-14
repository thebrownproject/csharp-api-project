using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;

namespace Supabase_Minimal_API.Models;

[Table("shift_type")]
public class ShiftTypeModel : BaseModel
{
    public ShiftTypeModel() {
        TypeName = string.Empty;
        DefaultStart = null;
        DefaultEnd = null;
        Description = string.Empty;
        IsActive = true;
    }
    
    public ShiftTypeModel(string typeName, ShiftTypeRequest request)
    {
        TypeName = typeName;
        DefaultStart = request.DefaultStart;
        DefaultEnd = request.DefaultEnd;
        Description = request.Description;
        IsActive = request.IsActive;
    }

    [PrimaryKey("type_name")]
    public string TypeName { get; set; }
    
    [Column("default_start")]
    public TimeOnly? DefaultStart { get; set; }
    
    [Column("default_end")]
    public TimeOnly? DefaultEnd { get; set; }
    
    [Column("description")]
    public string? Description { get; set; }
    
    [Column("is_active")]
    public bool IsActive { get; set; }
}

// CREATE TABLE shift_type (
//     type_name VARCHAR(50) PRIMARY KEY,
//     default_start TIME NOT NULL,
//     default_end TIME NOT NULL,
//     description TEXT,
//     is_active BOOLEAN DEFAULT TRUE
// );
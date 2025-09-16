using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("shift_type")]
public class ShiftTypeModel : BaseModel
{
    public ShiftTypeModel()
    {
        TypeName = string.Empty;
        DefaultStart = TimeSpan.MinValue;
        DefaultEnd = TimeSpan.MinValue;
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

    [PrimaryKey("type_name", true)]
    public string TypeName { get; set; }

    [Supabase.Postgrest.Attributes.Column("default_start")]
    public TimeSpan DefaultStart { get; set; }

    [Supabase.Postgrest.Attributes.Column("default_end")]
    public TimeSpan DefaultEnd { get; set; }

    [Supabase.Postgrest.Attributes.Column("description")]
    public string? Description { get; set; }

    [Supabase.Postgrest.Attributes.Column("is_active")]
    public bool IsActive { get; set; }
}

// CREATE TABLE shift_type (
//     type_name VARCHAR(50) PRIMARY KEY,
//     default_start TIME NOT NULL,
//     default_end TIME NOT NULL,
//     description TEXT,
//     is_active BOOLEAN DEFAULT TRUE
// );
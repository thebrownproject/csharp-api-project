using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using min_api_project.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace min_api_project.Models;

[Supabase.Postgrest.Attributes.Table("animal_note")]
public class AnimalNoteModel : BaseModel
{
    public AnimalNoteModel()
    {
        Id = Guid.Empty;
        AnimalId = Guid.Empty;
        UserId = Guid.Empty;
        NoteDate = DateOnly.MinValue;
        NoteContent = string.Empty;
        NoteType = string.Empty;
        CreatedAt = DateTime.MinValue;
    }

    public AnimalNoteModel(Guid id, AnimalNoteRequest request)
    {
        Id = id;
        AnimalId = request.AnimalId;
        UserId = request.UserId;
        NoteDate = DateOnly.FromDateTime(request.NoteDate);
        NoteContent = request.NoteContent;
        NoteType = request.NoteType;
        CreatedAt = DateTime.UtcNow;
    }

    [PrimaryKey("id")]
    public Guid Id { get; set; }
    [ForeignKey("animal_id")]
    [Supabase.Postgrest.Attributes.Column("animal_id")]
    public Guid AnimalId { get; set; }

    [ForeignKey("user_id")]
    [Supabase.Postgrest.Attributes.Column("user_id")]
    public Guid UserId { get; set; }

    [Supabase.Postgrest.Attributes.Column("note_date")]
    public DateOnly NoteDate { get; set; }

    [Supabase.Postgrest.Attributes.Column("note_content")]
    public string NoteContent { get; set; }

    [Supabase.Postgrest.Attributes.Column("note_type")]
    public string NoteType { get; set; }

    [Supabase.Postgrest.Attributes.Column("created_at")]
    public DateTime CreatedAt { get; set; }
}


// CREATE TABLE animal_note (
//     id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
//     animal_id UUID NOT NULL REFERENCES animal(id) ON DELETE CASCADE,
//     user_id UUID NOT NULL REFERENCES "user"(id) ON DELETE CASCADE,
//     note_date DATE NOT NULL DEFAULT CURRENT_DATE,
//     note_content TEXT NOT NULL,
//     note_type VARCHAR(50) DEFAULT 'General' CHECK (note_type IN ('General', 'Behavioral', 'Medical', 'Feeding', 'Exercise', 'Grooming', 'Training')),
//     created_at TIMESTAMP DEFAULT NOW()
// );
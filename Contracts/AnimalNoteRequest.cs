using System.ComponentModel.DataAnnotations;

namespace min_api_project.Contracts;

public class AnimalNoteRequest
{
    [Required]
    public required Guid AnimalId { get; set; }
    [Required]
    public required Guid UserId { get; set; }
    public DateTime NoteDate { get; set; } = DateTime.Today;
    [Required]
    public required string NoteContent { get; set; }
    [AllowedValues(["General", "Behavioral", "Medical", "Feeding", "Exercise", "Grooming", "Training"])]
    public string NoteType { get; set; } = "General";
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
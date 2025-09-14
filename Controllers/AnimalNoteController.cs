using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class AnimalNoteController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] AnimalNoteRequest request,
        [FromServices] Client client
    )
    {
        AnimalNoteModel animalNote = new AnimalNoteModel(Guid.Empty, request);
        ModeledResponse<AnimalNoteModel> response = await client.From<AnimalNoteModel>().Insert(animalNote);
        AnimalNoteModel newAnimalNote = response.Models.First();
        return Ok(newAnimalNote);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<AnimalNoteModel> response = await client.From<AnimalNoteModel>().Where(i => i.Id == id).Get();
        AnimalNoteModel? animalNote = response.Models.FirstOrDefault();
        if (animalNote is null) return NotFound();
        return Ok(animalNote);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] AnimalNoteRequest request, [FromServices] Client client)
    {
        AnimalNoteModel animalNote = new AnimalNoteModel(id, request);
        ModeledResponse<AnimalNoteModel> response = await client.From<AnimalNoteModel>().Where(i => i.Id == id).Update(animalNote);
        AnimalNoteModel? updatedAnimalNote = response.Models.FirstOrDefault();
        if (updatedAnimalNote is null) return NotFound();
        return Ok(updatedAnimalNote);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<AnimalNoteModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
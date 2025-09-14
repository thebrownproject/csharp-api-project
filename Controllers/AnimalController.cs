using Microsoft.AspNetCore.Mvc;
using min_api_project.Contracts;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;


[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] AnimalRequest request, 
        [FromServices] Client client
        )
        {
            AnimalModel animal = new AnimalModel(Guid.Empty, request);
            ModeledResponse<AnimalModel> response = await client.From<AnimalModel>().Insert(animal);
            AnimalModel newAnimal = response.Models.First();
            return Ok(newAnimal);
        }

    // Read
    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<AnimalModel> response = await client.From<AnimalModel>().Where(i => i.Id == id).Get();
        AnimalModel? animal = response.Models.FirstOrDefault();
        if (animal is null) return NotFound();
        return Ok(animal);
    }

    // Update
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] AnimalRequest request, [FromServices] Client client)
    {
        AnimalModel animal = new AnimalModel(id, request);
        ModeledResponse<AnimalModel> response = await client.From<AnimalModel>().Where(i => i.Id == id).Update(animal);
        AnimalModel? updatedAnimal = response.Models.FirstOrDefault();
        if (updatedAnimal is null) return NotFound();
        return Ok(updatedAnimal);
    }

    // Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client) 
    {
        await client.From<AnimalModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }   
}
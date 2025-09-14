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
}
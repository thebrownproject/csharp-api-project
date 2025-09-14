using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class AdoptionController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] AdoptionRequest request,
        [FromServices] Client client
    )
    {
        AdoptionModel adoption = new AdoptionModel(Guid.Empty, request);
        ModeledResponse<AdoptionModel> response = await client.From<AdoptionModel>().Insert(adoption);
        AdoptionModel newAdoption = response.Models.First();
        return Ok(newAdoption);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<AdoptionModel> response = await client.From<AdoptionModel>().Where(i => i.Id == id).Get();
        AdoptionModel? adoption = response.Models.FirstOrDefault();
        if (adoption is null) return NotFound();
        return Ok(adoption);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] AdoptionRequest request, [FromServices] Client client)
    {
        AdoptionModel adoption = new AdoptionModel(id, request);
        ModeledResponse<AdoptionModel> response = await client.From<AdoptionModel>().Where(i => i.Id == id).Update(adoption);
        AdoptionModel? updatedAdoption = response.Models.FirstOrDefault();
        if (updatedAdoption is null) return NotFound();
        return Ok(updatedAdoption);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<AdoptionModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
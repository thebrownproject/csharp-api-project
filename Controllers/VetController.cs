using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase_Minimal_API.Models;

[ApiController]
[Route("[controller]")]
public class VetController : ControllerBase
{
    // Create
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] CreateVetRequest request,
        [FromServices] Client client
    )
    {
        var vet = new VetModel
        {
            Title = request.Title,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Phone = request.Phone,
            ClinicName = request.ClinicName,
            ClinicAddress = request.ClinicAddress,
            CreatedAt = request.CreatedAt,
            UpdatedAt = request.UpdatedAt
        };

        var response = await client.From<VetModel>().Insert(vet);
        var newVet = response.Models.First();
        return Ok(newVet.Id);
    }

    // Read
    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        var response = await client.From<VetModel>().Where(i => i.Id == id).Get();

        var vet = response.Models.FirstOrDefault();

        if (vet == null) return NotFound();
        return Ok(vet);
    }

    // Update
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] VetModel updatedVetModel, [FromServices] Client client)
    {
        updatedVetModel.Id = id;
        var response = await client.From<VetModel>()
        .Where(i => i.Id == id).Update(updatedVetModel);

        if (updatedVetModel is null)
            return NotFound();

        return Ok(updatedVetModel);
    }

    // Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<VetModel>()
        .Where(i => i.Id == id).Delete();

        return NoContent();
    }

}

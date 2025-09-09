using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using Supabase_Minimal_API.Models;

// Marks it as an API controller with automatic model validation
[ApiController]
// [Route("[controller]")] - Creates routes like /Vet/ (the [controller] token gets replaced with "Vet")
[Route("[controller]")]
// VetController new class
public class VetController : ControllerBase
{
    // Create
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        // FromBody is used to pass the request body on swagger
        [FromBody] VetRequest request,
        // FromServices is used to pass the client to the controller
        [FromServices] Client client
    )
    {
        // Create a new vet variable using the VetModel constructor
        // and inserts the request parameter into the vet variable
        VetModel vet = new VetModel(Guid.Empty, request);

        // Inserts the vet variable into the database
        ModeledResponse<VetModel> response = await client.From<VetModel>().Insert(vet);
        
        // Gets the new vet from the database
        VetModel newVet = response.Models.First();
        // Returns the new vet
        return Ok(newVet);
    }

    // Read
    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        // FromServices is used to pass the client to the controller
        Guid id, [FromServices] Client client)
    {
        // Gets the vet by id from the database
        ModeledResponse<VetModel> response = await client.From<VetModel>().Where(i => i.Id == id).Get();

        // Gets the vet from the database and store it in the vet variable
        VetModel? vet = response.Models.FirstOrDefault();

        // If the vet is not found, return error
        if (vet is null) return NotFound();
        // Returns the vet
        return Ok(vet);
    }

    // Update
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        // FromBody is used to pass the request body on swagger
        Guid id, [FromBody] VetRequest request, [FromServices] Client client)
    {
        // Creates a new vet variable using the VetModel constructor
        VetModel vet = new VetModel(id, request);
        
        // Updates the vet in the database
        ModeledResponse<VetModel> response = await client.From<VetModel>().Where(i => i.Id == id).Update(vet);

        // Gets the updated vet from the database
        VetModel? updatedVet = response.Models.FirstOrDefault();

        // If the updated vet is not found, return error
        if (updatedVet is null)
            return NotFound();
        // Returns the updated vet
        return Ok(updatedVet);
    }

    // Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        // Deletes the vet from the database
        await client.From<VetModel>()
        .Where(i => i.Id == id).Delete();

        // Returns no content
        return NoContent();
    }
}

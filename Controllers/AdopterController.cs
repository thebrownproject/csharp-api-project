using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using Supabase_Minimal_API.Models;

// Nominate the controller as an API controller
[ApiController]
// Route the controller to the active volunteer endpoint
[Route("[controller]")]
// ActiveVolunteersController new class
public class AdopterController : ControllerBase
{
    // Create
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        // FromBody is used to pass the request body on swagger
        [FromBody] AdopterRequest request,
        // FromServices is used to pass the client to the controller
        [FromServices] Client client
    )
    {
        // Create a new adopter variable using the AdopterModel constructor
        AdopterModel adopter = new AdopterModel(Guid.Empty, request);

        // Insert the adopter into the database
        ModeledResponse<AdopterModel> response = await client.From<AdopterModel>().Insert(adopter);

        // Get the new adopter from the database
        AdopterModel newAdopter = response.Models.First();
        // Return the new adopter
        return Ok(newAdopter);
    }

    // Read
    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        // FromServices is used to pass the client to the controller
        Guid id, [FromServices] Client client)
        {
            // Get the adopter by id from the database
            ModeledResponse<AdopterModel> response = await client.From<AdopterModel>().Where(i => i.Id == id).Get();

            // Get the adopter from the database
            AdopterModel? adopter = response.Models.FirstOrDefault();

            // If the adopter is not found, return error
            if (adopter is null) return NotFound();
            // Return the adopter
            return Ok(adopter);
        }

    // Update
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        // FromBody is used to pass the request body on swagger
        Guid id, [FromBody] AdopterRequest request, [FromServices] Client client)
        {
            // Create a new adopter variable using the AdopterModel constructor
            AdopterModel adopter = new AdopterModel(id, request);

            // Update the adopter in the database
            ModeledResponse<AdopterModel> response = await client.From<AdopterModel>().Where(i => i.Id == id).Update(adopter);

            // Get the updated adopter from the database
            AdopterModel? updatedAdopter = response.Models.FirstOrDefault();

            // If the updated adopter is not found, return error
            if (updatedAdopter is null) return NotFound();
            // Return the updated adopter
            return Ok(updatedAdopter);
        }

    // Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
        {
            // Delete the adopter from the database
            await client.From<AdopterModel>().Where(i => i.Id == id).Delete();

            // Return no content
            return NoContent();
        }
}

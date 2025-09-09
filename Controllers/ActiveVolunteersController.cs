using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using Supabase_Minimal_API.Models;

// Nominate the controller as an API controller
[ApiController]
// Route the controller to the active volunteer endpoint
[Route("[controller]")]
// ActiveVolunteersController new class
public class ActiveVolunteersController : ControllerBase
{
    // Create
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        // FromBody is used to pass the request body on swagger
        [FromBody] ActiveVolunteersRequest request,
        // FromServices is used to pass the client to the controller
        [FromServices] Client client
    )
    {
        // Create a new active volunteer variable using the ActiveVolunteerModel constructor
    }
}

using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase_Minimal_API.Models;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    // Create
    [HttpPost("{id}")]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] CreateUserRequest request,
        [FromServices] Client client
    )
    {

    }

    // Read
    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        int id, [FromServices] Client client)
    {

    }

    // Update
    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        int id, [FromBody] UserModel updatedUserModel, [FromServices] Client client)
    {

    }

    // Delete
    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(int id, [FromServices] Client client)
    {

    }

}

public class CreateUserRequest
{
}
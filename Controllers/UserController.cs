using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] UserRequest request,
        [FromServices] Client client
    )
    {
        UserModel user = new UserModel(Guid.Empty, request);
        ModeledResponse<UserModel> response = await client.From<UserModel>().Insert(user);
        UserModel newUser = response.Models.First();
        return Ok(newUser);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<UserModel> response = await client.From<UserModel>().Where(i => i.Id == id).Get();
        UserModel? user = response.Models.FirstOrDefault();
        if (user is null) return NotFound();
        return Ok(user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] UserRequest request, [FromServices] Client client)
    {
        UserModel user = new UserModel(id, request);
        ModeledResponse<UserModel> response = await client.From<UserModel>().Where(i => i.Id == id).Update(user);
        UserModel? updatedUser = response.Models.FirstOrDefault();
        if (updatedUser is null) return NotFound();
        return Ok(updatedUser);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<UserModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class HealthCheckController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] HealthCheckRequest request,
        [FromServices] Client client
    )
    {
        HealthCheckModel healthCheck = new HealthCheckModel(Guid.Empty, request);
        ModeledResponse<HealthCheckModel> response = await client.From<HealthCheckModel>().Insert(healthCheck);
        HealthCheckModel newHealthCheck = response.Models.First();
        return Ok(newHealthCheck);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<HealthCheckModel> response = await client.From<HealthCheckModel>().Where(i => i.Id == id).Get();
        HealthCheckModel? healthCheck = response.Models.FirstOrDefault();
        if (healthCheck is null) return NotFound();
        return Ok(healthCheck);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] HealthCheckRequest request, [FromServices] Client client)
    {
        HealthCheckModel healthCheck = new HealthCheckModel(id, request);
        ModeledResponse<HealthCheckModel> response = await client.From<HealthCheckModel>().Where(i => i.Id == id).Update(healthCheck);
        HealthCheckModel? updatedHealthCheck = response.Models.FirstOrDefault();
        if (updatedHealthCheck is null) return NotFound();
        return Ok(updatedHealthCheck);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<HealthCheckModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
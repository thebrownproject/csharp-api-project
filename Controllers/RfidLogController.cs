using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class RfidLogController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] RfidLogRequest request,
        [FromServices] Client client
    )
    {
        RfidLogModel rfidLog = new RfidLogModel(Guid.Empty, request);
        ModeledResponse<RfidLogModel> response = await client.From<RfidLogModel>().Insert(rfidLog);
        RfidLogModel newRfidLog = response.Models.First();
        return Ok(newRfidLog);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<RfidLogModel> response = await client.From<RfidLogModel>().Where(i => i.Id == id).Get();
        RfidLogModel? rfidLog = response.Models.FirstOrDefault();
        if (rfidLog is null) return NotFound();
        return Ok(rfidLog);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] RfidLogRequest request, [FromServices] Client client)
    {
        RfidLogModel rfidLog = new RfidLogModel(id, request);
        ModeledResponse<RfidLogModel> response = await client.From<RfidLogModel>().Where(i => i.Id == id).Update(rfidLog);
        RfidLogModel? updatedRfidLog = response.Models.FirstOrDefault();
        if (updatedRfidLog is null) return NotFound();
        return Ok(updatedRfidLog);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<RfidLogModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
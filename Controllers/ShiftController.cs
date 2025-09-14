using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class ShiftController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] ShiftRequest request,
        [FromServices] Client client
    )
    {
        ShiftModel shift = new ShiftModel(0, request);
        ModeledResponse<ShiftModel> response = await client.From<ShiftModel>().Insert(shift);
        ShiftModel newShift = response.Models.First();
        return Ok(newShift);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        int id, [FromServices] Client client)
    {
        ModeledResponse<ShiftModel> response = await client.From<ShiftModel>().Where(i => i.ShiftId == id).Get();
        ShiftModel? shift = response.Models.FirstOrDefault();
        if (shift is null) return NotFound();
        return Ok(shift);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        int id, [FromBody] ShiftRequest request, [FromServices] Client client)
    {
        ShiftModel shift = new ShiftModel(id, request);
        ModeledResponse<ShiftModel> response = await client.From<ShiftModel>().Where(i => i.ShiftId == id).Update(shift);
        ShiftModel? updatedShift = response.Models.FirstOrDefault();
        if (updatedShift is null) return NotFound();
        return Ok(updatedShift);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(int id, [FromServices] Client client)
    {
        await client.From<ShiftModel>().Where(i => i.ShiftId == id).Delete();
        return NoContent();
    }
}

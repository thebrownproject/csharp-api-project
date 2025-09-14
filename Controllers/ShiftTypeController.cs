using Microsoft.AspNetCore.Mvc;
using Supabase;
using Supabase.Postgrest.Responses;
using min_api_project.Models;
using min_api_project.Contracts;

[ApiController]
[Route("[controller]")]
public class ShiftTypeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> OnPostAsync(
        [FromBody] ShiftTypeRequest request,
        [FromServices] Client client
    )
    {
        ShiftTypeModel shiftType = new ShiftTypeModel(request.TypeName, request);
        ModeledResponse<ShiftTypeModel> response = await client.From<ShiftTypeModel>().Insert(shiftType);
        ShiftTypeModel newShiftType = response.Models.First();
        return Ok(newShiftType);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> OnGetAsync(
        Guid id, [FromServices] Client client)
    {
        ModeledResponse<ShiftTypeModel> response = await client.From<ShiftTypeModel>().Where(i => i.Id == id).Get();
        ShiftTypeModel? shiftType = response.Models.FirstOrDefault();
        if (shiftType is null) return NotFound();
        return Ok(shiftType);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> OnPutAsync(
        Guid id, [FromBody] ShiftTypeRequest request, [FromServices] Client client)
    {
        ShiftTypeModel shiftType = new ShiftTypeModel(id, request);
        ModeledResponse<ShiftTypeModel> response = await client.From<ShiftTypeModel>().Where(i => i.Id == id).Update(shiftType);
        ShiftTypeModel? updatedShiftType = response.Models.FirstOrDefault();
        if (updatedShiftType is null) return NotFound();
        return Ok(updatedShiftType);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> OnDeleteAsync(Guid id, [FromServices] Client client)
    {
        await client.From<ShiftTypeModel>().Where(i => i.Id == id).Delete();
        return NoContent();
    }
}
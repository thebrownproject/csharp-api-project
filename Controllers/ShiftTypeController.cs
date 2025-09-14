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

    [HttpGet("{typeName}")]
    public async Task<IActionResult> OnGetAsync(
        string typeName, [FromServices] Client client)
    {
        ModeledResponse<ShiftTypeModel> response = await client.From<ShiftTypeModel>().Where(i => i.TypeName == typeName).Get();
        ShiftTypeModel? shiftType = response.Models.FirstOrDefault();
        if (shiftType is null) return NotFound();
        return Ok(shiftType);
    }

    [HttpPut("{typeName}")]
    public async Task<IActionResult> OnPutAsync(
        string typeName, [FromBody] ShiftTypeRequest request, [FromServices] Client client)
    {
        ShiftTypeModel shiftType = new ShiftTypeModel(typeName, request);
        ModeledResponse<ShiftTypeModel> response = await client.From<ShiftTypeModel>().Where(i => i.TypeName == typeName).Update(shiftType);
        ShiftTypeModel? updatedShiftType = response.Models.FirstOrDefault();
        if (updatedShiftType is null) return NotFound();
        return Ok(updatedShiftType);
    }

    [HttpDelete("{typeName}")]
    public async Task<IActionResult> OnDeleteAsync(string typeName, [FromServices] Client client)
    {
        await client.From<ShiftTypeModel>().Where(i => i.TypeName == typeName).Delete();
        return NoContent();
    }
}
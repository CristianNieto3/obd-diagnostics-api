using Microsoft.AspNetCore.Mvc;
using PulseOBD.Models;
using PulseOBD.Repositories;

namespace PulseOBD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IVehicleRepository _vehicleRepository;

    public VehicleController(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var vehicles = await _vehicleRepository.GetAll();
        return Ok(vehicles);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var vehicle = await _vehicleRepository.GetById(id);

        if (vehicle is null)
        {
            return NotFound();
        }

        return Ok(vehicle);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Vehicle? vehicle)
    {
        if (vehicle is null)
        {
            return BadRequest();
        }

        vehicle.CreatedAt = DateTime.UtcNow;

        var createdVehicle = await _vehicleRepository.AddVehicle(vehicle);
        return CreatedAtAction(nameof(GetById), new { id = createdVehicle.Id }, createdVehicle);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] Vehicle? vehicle)
    {
        if (vehicle is null)
        {
            return BadRequest();
        }

        try
        {
            await _vehicleRepository.UpdateById(id, vehicle);
            return NoContent();
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _vehicleRepository.DeleteById(id);
            return NoContent();
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }
}

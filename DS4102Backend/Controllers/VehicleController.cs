#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DS4102Backend.Models;

namespace DS4102Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly ArmyContext _context;

    public VehicleController(ArmyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Vehicle>>> Get()
    {
        List<Vehicle> vehicles = await _context.Vehicles.ToListAsync();
        return vehicles;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicle>> Get(int id)
    {
        Vehicle vehicles = await _context.Vehicles.FindAsync(id);
        return vehicles;
    }

    [HttpPut]
    public async Task<ActionResult<Vehicle>> Put(Vehicle editedVehicle)
    {
        _context.Entry(editedVehicle).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return editedVehicle;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        Vehicle vehicles = await _context.Vehicles.FindAsync(id);
        _context.Vehicles.Remove(vehicles);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Vehicle vehicle)
    {
        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();
        return StatusCode(201);
    }  
}
#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DS4102Backend.Models;

namespace DS4102Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class SoldierController : ControllerBase
{
    private readonly ArmyContext _context;

    public SoldierController(ArmyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Soldier>>> Get()
    {
        List<Soldier> soldiers = await _context.Soldiers.ToListAsync();
        return soldiers;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Soldier>> Get(int id)
    {
        Soldier soldiers = await _context.Soldiers.FindAsync(id);
        return soldiers;
    }

    [HttpPut]
    public async Task<ActionResult<Soldier>> Put(Soldier editedSoldier)
    {
        _context.Entry(editedSoldier).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return editedSoldier;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        Soldier soldiers = await _context.Soldiers.FindAsync(id);
        _context.Soldiers.Remove(soldiers);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Soldier soldier)
    {
        _context.Soldiers.Add(soldier);
        await _context.SaveChangesAsync();
        return StatusCode(201);
    }  

}
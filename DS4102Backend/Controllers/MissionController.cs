#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DS4102Backend.Models;

namespace DS4102Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class MissionController : ControllerBase
{
    private readonly ArmyContext _context;

    public MissionController(ArmyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Mission>>> Get()
    {
        List<Mission> missions = await _context.Missions.ToListAsync();
        return missions;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Mission>> Get(int id)
    {
        Mission missions = await _context.Missions.FindAsync(id);
        return missions;
    }

    [HttpPut]
    public async Task<ActionResult<Mission>> Put(Mission editedMission)
    {
        _context.Entry(editedMission).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return editedMission;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        Mission missions = await _context.Missions.FindAsync(id);
        _context.Missions.Remove(missions);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Mission mission)
    {
        _context.Missions.Add(mission);
        await _context.SaveChangesAsync();
        return StatusCode(201);
    }  

}
#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DS4102Backend.Models;

namespace DS4102Backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeaponController : ControllerBase
{
    private readonly ArmyContext _context;

    public WeaponController(ArmyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Weapon>>> Get()
    {
        List<Weapon> weapons = await _context.Weapons.ToListAsync();
        return weapons;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Weapon>> Get(int id)
    {
        Weapon weapons = await _context.Weapons.FindAsync(id);
        return weapons;
    }

    [HttpPut]
    public async Task<ActionResult<Weapon>> Put(Weapon editedWeapon)
    {
        _context.Entry(editedWeapon).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return editedWeapon;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        Weapon weapons = await _context.Weapons.FindAsync(id);
        _context.Weapons.Remove(weapons);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Post(Weapon weapon)
    {
        _context.Weapons.Add(weapon);
        await _context.SaveChangesAsync();
        return StatusCode(201);
    }  
}
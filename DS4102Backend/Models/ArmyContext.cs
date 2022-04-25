#nullable disable
using Microsoft.EntityFrameworkCore;

namespace DS4102Backend.Models;

public class ArmyContext : DbContext
{
    public ArmyContext(DbContextOptions<ArmyContext> options):base(options){}
    
    public DbSet<DS4102Backend.Models.Soldier> Soldiers { get; set; }
    public DbSet<DS4102Backend.Models.Vehicle> Vehicles { get; set; }
    public DbSet<DS4102Backend.Models.Weapon> Weapons { get; set; }
    public DbSet<DS4102Backend.Models.Mission> Missions { get; set; }
}

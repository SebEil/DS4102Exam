#nullable disable
using Microsoft.EntityFrameworkCore;

namespace DS4102Backend.Models;

public class ArmyContext : DbContext
{
    public ArmyContext(DbContextOptions<ArmyContext> options):base(options){}
    public DbSet<DS4102Backend.Models.Soldier> Soldier { get; set; }
    public DbSet<DS4102Backend.Models.Vehicle> Vehicle { get; set; }
    public DbSet<DS4102Backend.Models.Weapon> Weapon { get; set; }
    public DbSet<DS4102Backend.Models.Mission> Mission { get; set; }
}

#nullable disable
using Microsoft.EntityFrameworkCore;

namespace SoldierApi.Models;

public class SoldierContext : DbContext
{
    public SoldierContext(DbContextOptions<SoldierContext> options):base(options){}
    public DbSet<SoldierApi.Models.Soldier> Soldier { get; set; }
    public DbSet<SoldierApi.Models.Vehicle> Vehicle { get; set; }
    public DbSet<SoldierApi.Models.Weapon> Weapon { get; set; }
    public DbSet<SoldierApi.Models.Mission> Mission { get; set; }
}

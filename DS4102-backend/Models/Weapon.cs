using System.ComponentModel.DataAnnotations;

namespace SoldierApi.Models;

public class Weapon
{
    [Key]
    public int WeaponId { get; set; }
    public string? WeaponName { get; set; }
    public string? WeaponCost { get; set; }
    public bool InUse { get; set; }
}
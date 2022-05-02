using System.ComponentModel.DataAnnotations;

namespace DS4102Backend.Models;

public class Weapon
{
    [Key]
    public int WeaponId { get; set; }
    public string? WeaponName { get; set; }
    public int? WeaponCost { get; set; }
    public bool? InUse { get; set; }
}
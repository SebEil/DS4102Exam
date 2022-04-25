using System.ComponentModel.DataAnnotations;

namespace DS4102Backend.Models;

public class Soldier
{
    [Key]
    public int SoldierId { get; set; }
    public string? SoldierName { get; set; }
    public string? Bloodtype { get; set; }
    public double Height { get; set; } //1.85m
    public string? Image { get; set; }
    public bool IsOnMission { get; set; }
}
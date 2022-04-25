using System.ComponentModel.DataAnnotations;

namespace SoldierApi.Models;

public class Vehicle
{
    [Key]
    public int VehicleId { get; set; }
    public string? VehicleType { get; set; }
    public bool IsRugged { get; set; }
    public int NumberOfSeats { get; set; }
}
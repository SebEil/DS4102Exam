using System.ComponentModel.DataAnnotations;

namespace DS4102Backend.Models;

public class Vehicle
{
    [Key]
    public int VehicleId { get; set; }
    public string? VehicleType { get; set; }
    public int NumberOfSeats { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace SoldierApi.Models;

public class Mission
{
    [Key]
    public int MissionId { get; set; }
    public string? MissionName { get; set; }
    public string? MissionLocation { get; set; }
    public int SoldiersDeployed { get; set; }
}
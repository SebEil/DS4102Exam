using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DS4102_Exam.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mission",
                columns: table => new
                {
                    MissionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MissionName = table.Column<string>(type: "TEXT", nullable: true),
                    MissionLocation = table.Column<string>(type: "TEXT", nullable: true),
                    SoldiersDeployed = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mission", x => x.MissionId);
                });

            migrationBuilder.CreateTable(
                name: "Soldier",
                columns: table => new
                {
                    SoldierId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SoldierName = table.Column<string>(type: "TEXT", nullable: true),
                    Bloodtype = table.Column<string>(type: "TEXT", nullable: true),
                    Height = table.Column<double>(type: "REAL", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    IsOnMission = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soldier", x => x.SoldierId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfSeats = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WeaponName = table.Column<string>(type: "TEXT", nullable: true),
                    WeaponCost = table.Column<string>(type: "TEXT", nullable: true),
                    InUse = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.WeaponId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mission");

            migrationBuilder.DropTable(
                name: "Soldier");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}

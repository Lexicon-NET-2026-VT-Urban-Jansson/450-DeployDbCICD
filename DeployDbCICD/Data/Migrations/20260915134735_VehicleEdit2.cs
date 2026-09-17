using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeployDbCICD.Data.Migrations
{
    /// <inheritdoc />
    public partial class VehicleEdit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Vehicles",
                newName: "ModelYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "Vehicles",
                newName: "Year");
        }
    }
}

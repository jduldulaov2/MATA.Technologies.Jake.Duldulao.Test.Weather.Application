using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTemperraturetoForecastTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Temperature",
                table: "Forecast",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Forecast");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCitytoForecastTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Forecast",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Forecast");
        }
    }
}

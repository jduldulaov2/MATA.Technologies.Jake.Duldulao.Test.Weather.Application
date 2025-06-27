using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateAdditionalTempData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
INSERT INTO Forecast (
    City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
    Pressure, Humidity, Temperature,
    UniqueId, Created, CreatedBy, LastModified
) VALUES
('Phoenix', 'Scorching Sun', 'Extreme heat expected', '2025-06-29', 'Hot', '1009', '15', '110.3', 
 'v1a7b760-e1b4-41c7-a6e1-000000000041', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Seattle', 'Drizzle', 'Light rain all day', '2025-06-29', 'Drizzle', '1011', '78', '61.2', 
 'v1a7b760-e1b4-41c7-a6e1-000000000042', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Denver', 'Mountain Winds', 'Windy and dry', '2025-06-29', 'Wind', '1018', '30', '75.0', 
 'v1a7b760-e1b4-41c7-a6e1-000000000043', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Miami', 'Tropical Rain', 'Heavy showers in the afternoon', '2025-06-29', 'Rain', '1007', '88', '85.9', 
 'v1a7b760-e1b4-41c7-a6e1-000000000044', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Atlanta', 'Humid Skies', 'High humidity with overcast skies', '2025-06-29', 'Humidity', '1013', '80', '86.4', 
 'v1a7b760-e1b4-41c7-a6e1-000000000045', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Chicago', 'Windy Day', 'Chilly winds from the north', '2025-06-29', 'Wind', '1022', '45', '68.0', 
 'v1a7b760-e1b4-41c7-a6e1-000000000046', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Dallas', 'Heat Advisory', 'Hot and dry conditions', '2025-06-29', 'Hot', '1010', '25', '104.7', 
 'v1a7b760-e1b4-41c7-a6e1-000000000047', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Las Vegas', 'Desert Heat', 'Extreme temperatures expected', '2025-06-29', 'Hot', '1006', '18', '112.1', 
 'v1a7b760-e1b4-41c7-a6e1-000000000048', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Minneapolis', 'Cool & Sunny', 'Clear skies with cool temps', '2025-06-29', 'Clear', '1017', '35', '70.5', 
 'v1a7b760-e1b4-41c7-a6e1-000000000049', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Detroit', 'Mild Conditions', 'Pleasant and calm', '2025-06-29', 'Clear', '1014', '48', '72.2', 
 'v1a7b760-e1b4-41c7-a6e1-000000000050', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Charlotte', 'Cloud Cover', 'Mostly cloudy skies', '2025-06-29', 'Clouds', '1012', '55', '77.0', 
 'v1a7b760-e1b4-41c7-a6e1-000000000051', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Jacksonville', 'Hot and Humid', 'Sun with high humidity', '2025-06-29', 'Humidity', '1009', '82', '90.6', 
 'v1a7b760-e1b4-41c7-a6e1-000000000052', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Memphis', 'Thunder Warnings', 'Storms rolling through in afternoon', '2025-06-29', 'Storm', '1005', '70', '82.7', 
 'v1a7b760-e1b4-41c7-a6e1-000000000053', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Louisville', 'Evening Storms', 'Cloudy with night thunderstorms', '2025-06-29', 'Storm', '1008', '65', '78.1', 
 'v1a7b760-e1b4-41c7-a6e1-000000000054', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('San Diego', 'Coastal Fog', 'Foggy morning clearing by noon', '2025-06-29', 'Fog', '1016', '55', '72.8', 
 'v1a7b760-e1b4-41c7-a6e1-000000000055', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Portland', 'Rainy Day', 'Steady showers expected', '2025-06-29', 'Rain', '1009', '85', '64.9', 
 'v1a7b760-e1b4-41c7-a6e1-000000000056', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Austin', 'Dry and Hot', 'Very hot with no clouds', '2025-06-29', 'Hot', '1007', '20', '106.2', 
 'v1a7b760-e1b4-41c7-a6e1-000000000057', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('San Antonio', 'Clear Skies', 'Sunny all day', '2025-06-29', 'Clear', '1011', '30', '98.4', 
 'v1a7b760-e1b4-41c7-a6e1-000000000058', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Orlando', 'Scattered Showers', 'Occasional rain expected', '2025-06-29', 'Rain', '1010', '78', '84.6', 
 'v1a7b760-e1b4-41c7-a6e1-000000000059', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Buffalo', 'Cloudy Afternoon', 'Cool with light clouds', '2025-06-29', 'Clouds', '1015', '60', '68.2', 
 'v1a7b760-e1b4-41c7-a6e1-000000000060', '2025-06-29', 'SystemSeeder', '2025-06-29'),
('Phoenix', 'Even Hotter', 'Dangerous heat levels', '2025-06-30', 'Hot', '1008', '12', '112.8', 
 'v1a7b760-e1b4-41c7-a6e1-000000000061', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Seattle', 'Wet Morning', 'Drizzle with cloudy skies', '2025-06-30', 'Drizzle', '1012', '76', '60.0', 
 'v1a7b760-e1b4-41c7-a6e1-000000000062', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Denver', 'Dry Heat', 'Hot and sunny with dry air', '2025-06-30', 'Clear', '1015', '22', '95.1', 
 'v1a7b760-e1b4-41c7-a6e1-000000000063', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Miami', 'Storm Watch', 'Heavy tropical rains expected', '2025-06-30', 'Storm', '1006', '90', '86.7', 
 'v1a7b760-e1b4-41c7-a6e1-000000000064', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Atlanta', 'Overcast', 'Cloudy with brief sunshine', '2025-06-30', 'Clouds', '1014', '70', '82.3', 
 'v1a7b760-e1b4-41c7-a6e1-000000000065', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Chicago', 'Cool Winds', 'Breezy and cool', '2025-06-30', 'Wind', '1020', '40', '69.7', 
 'v1a7b760-e1b4-41c7-a6e1-000000000066', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Dallas', 'Heat Wave', 'Severe heat alert', '2025-06-30', 'Hot', '1009', '19', '107.9', 
 'v1a7b760-e1b4-41c7-a6e1-000000000067', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Las Vegas', 'Blistering Heat', 'Record-breaking temperatures', '2025-06-30', 'Hot', '1005', '10', '114.2', 
 'v1a7b760-e1b4-41c7-a6e1-000000000068', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Minneapolis', 'Pleasant Day', 'Mild and sunny', '2025-06-30', 'Clear', '1016', '34', '72.0', 
 'v1a7b760-e1b4-41c7-a6e1-000000000069', '2025-06-30', 'SystemSeeder', '2025-06-30'),
('Detroit', 'Steady Clouds', 'Mild with constant cloud cover', '2025-06-30', 'Clouds', '1013', '50', '71.8', 
 'v1a7b760-e1b4-41c7-a6e1-000000000070', '2025-06-30', 'SystemSeeder', '2025-06-30');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Forecast
                WHERE CreatedBy = 'SystemSeeder' AND Created in ('2025-06-29','2025-06-30');
            ");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add20TemporaryDataForForecastTable : Migration
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
                ('New York', 'Sunny', 'Clear skies all day', '2025-06-27', 'Clear', '1012', '50', '85.0', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000001', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Los Angeles', 'Overcast', 'Cloudy throughout the day', '2025-06-27', 'Clouds', '1010', '55', '75.2', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000002', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Chicago', 'Rainy Day', 'Showers expected in the afternoon', '2025-06-27', 'Rain', '1008', '70', '68.5', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000003', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Houston', 'Hot and Humid', 'Very high temperatures with humidity', '2025-06-27', 'Hot', '1015', '80', '95.1', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000004', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Phoenix', 'Dry Heat', 'Sunny and dry', '2025-06-27', 'Clear', '1005', '20', '104.3', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000005', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Seattle', 'Light Drizzle', 'Occasional drizzle', '2025-06-27', 'Drizzle', '1011', '78', '66.0', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000006', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Miami', 'Thunderstorms', 'Storms and heavy rain expected', '2025-06-27', 'Storm', '1007', '90', '88.2', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000007', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Denver', 'Clear Skies', 'Mild weather with clear skies', '2025-06-27', 'Clear', '1020', '40', '72.6', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000008', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Boston', 'Windy Day', 'Strong winds in the evening', '2025-06-27', 'Wind', '1009', '50', '69.8', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000009', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('San Francisco', 'Foggy Morning', 'Fog clears by noon', '2025-06-27', 'Fog', '1013', '65', '61.7', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000010', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Atlanta', 'Partly Cloudy', 'Some clouds with sun breaks', '2025-06-27', 'Clouds', '1010', '60', '81.5', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000011', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Dallas', 'Scattered Thunderstorms', 'Storms developing late afternoon', '2025-06-27', 'Storm', '1006', '75', '87.4', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000012', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('San Diego', 'Breezy', 'Windy with sunny intervals', '2025-06-27', 'Wind', '1014', '45', '76.3', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000013', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Philadelphia', 'Warm and Clear', 'Sunny and warm', '2025-06-27', 'Clear', '1011', '55', '83.2', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000014', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Minneapolis', 'Cold Front', 'Chilly with clear skies', '2025-06-27', 'Clear', '1022', '35', '58.0', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000015', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Portland', 'Drizzle', 'Rain likely throughout the day', '2025-06-27', 'Rain', '1009', '85', '64.4', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000016', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Las Vegas', 'Very Hot', 'Scorching sun and dry air', '2025-06-27', 'Hot', '1002', '15', '108.7', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000017', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Orlando', 'Rain Showers', 'Morning rain, clearing later', '2025-06-27', 'Rain', '1010', '70', '84.9', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000018', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Austin', 'Cloudy', 'Clouds with occasional sunshine', '2025-06-27', 'Clouds', '1013', '60', '82.0', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000019', '2025-06-27', 'SystemSeeder', '2025-06-27'),
                ('Charlotte', 'Thunderstorm Watch', 'Possible thunderstorms in the PM', '2025-06-27', 'Storm', '1008', '68', '86.5', 
                 'd1a7b760-e1b4-41c7-a6e1-000000000020', '2025-06-27', 'SystemSeeder', '2025-06-27');
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Forecast
                WHERE CreatedBy = 'SystemSeeder' AND Created = '2025-06-27';
            ");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateAdditionalTempData2 : Migration
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
      ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-06-28', 'Humidity', '1012', '85', '82.5', 
       'v1a7b760-e1b4-41c7-a6e1-000000000021', '2025-06-28', 'SystemSeeder', '2025-06-28'),
      ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-06-28', 'Clouds', '1011', '50', '79.8', 
       'v1a7b760-e1b4-41c7-a6e1-000000000022', '2025-06-28', 'SystemSeeder', '2025-06-28'),
      ('Columbus', 'Clear', 'Clear skies and sunny', '2025-06-28', 'Clear', '1013', '45', '80.1', 
       'v1a7b760-e1b4-41c7-a6e1-000000000023', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-06-26', 'Rain', '1009', '70', '67.2', 
       'v1a7b760-e1b4-41c7-a6e1-000000000024', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-06-26', 'Clear', '1015', '20', '96.3', 
       'v1a7b760-e1b4-41c7-a6e1-000000000025', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-06-26', 'Storm', '1005', '90', '73.0', 
       'v1a7b760-e1b4-41c7-a6e1-000000000026', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-06-26', 'Wind', '1020', '40', '68.9', 
       'v1a7b760-e1b4-41c7-a6e1-000000000027', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-06-26', 'Clouds', '1012', '60', '70.6', 
       'v1a7b760-e1b4-41c7-a6e1-000000000028', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-06-26', 'Storm', '1006', '80', '74.3', 
       'v1a7b760-e1b4-41c7-a6e1-000000000029', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-06-26', 'Hot', '1011', '65', '91.4', 
       'v1a7b760-e1b4-41c7-a6e1-000000000030', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-06-26', 'Wind', '1021', '30', '60.1', 
       'v1a7b760-e1b4-41c7-a6e1-000000000031', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-06-26', 'Hot', '1010', '88', '89.9', 
       'v1a7b760-e1b4-41c7-a6e1-000000000032', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-06-26', 'Storm', '1007', '92', '85.7', 
       'v1a7b760-e1b4-41c7-a6e1-000000000033', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-06-26', 'Storm', '1008', '50', '83.3', 
       'v1a7b760-e1b4-41c7-a6e1-000000000034', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-06-26', 'Clear', '1006', '25', '101.2', 
       'v1a7b760-e1b4-41c7-a6e1-000000000035', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-06-26', 'Clouds', '1014', '55', '76.0', 
       'v1a7b760-e1b4-41c7-a6e1-000000000036', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-06-26', 'Fog', '1012', '68', '71.4', 
       'v1a7b760-e1b4-41c7-a6e1-000000000037', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-06-26', 'Clear', '1016', '28', '88.0', 
       'v1a7b760-e1b4-41c7-a6e1-000000000038', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-06-26', 'Clear', '1010', '60', '86.6', 
       'v1a7b760-e1b4-41c7-a6e1-000000000039', '2025-06-26', 'SystemSeeder', '2025-06-26'),
      ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-06-26', 'Clear', '1023', '40', '58.7', 
       'v1a7b760-e1b4-41c7-a6e1-000000000040', '2025-06-26', 'SystemSeeder', '2025-06-26');
 ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Forecast
                WHERE CreatedBy = 'SystemSeeder' AND Created = '2025-06-26';
            ");
        }
    }
}

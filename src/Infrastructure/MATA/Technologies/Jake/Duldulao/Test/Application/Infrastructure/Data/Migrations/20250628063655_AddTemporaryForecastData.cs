using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MATA.Technologies.Jake.Duldulao.Test.Application.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTemporaryForecastData : Migration
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
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-01', 'Humidity', '1012', '85', '82.5', 
      'by57b760-e1b4-41c7-a6e1-000000000021', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-01', 'Clouds', '1011', '50', '79.8', 
      'by57b760-e1b4-41c7-a6e1-000000000022', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-01', 'Clear', '1013', '45', '80.1', 
      'by57b760-e1b4-41c7-a6e1-000000000023', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-01', 'Rain', '1009', '70', '67.2', 
      'by57b760-e1b4-41c7-a6e1-000000000024', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-01', 'Clear', '1015', '20', '96.3', 
      'by57b760-e1b4-41c7-a6e1-000000000025', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-01', 'Storm', '1005', '90', '73.0', 
      'by57b760-e1b4-41c7-a6e1-000000000026', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-01', 'Wind', '1020', '40', '68.9', 
      'by57b760-e1b4-41c7-a6e1-000000000027', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-01', 'Clouds', '1012', '60', '70.6', 
      'by57b760-e1b4-41c7-a6e1-000000000028', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-01', 'Storm', '1006', '80', '74.3', 
      'by57b760-e1b4-41c7-a6e1-000000000029', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-01', 'Hot', '1011', '65', '91.4', 
      'by57b760-e1b4-41c7-a6e1-000000000030', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-01', 'Wind', '1021', '30', '60.1', 
      'by57b760-e1b4-41c7-a6e1-000000000031', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-01', 'Hot', '1010', '88', '89.9', 
      'by57b760-e1b4-41c7-a6e1-000000000032', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-01', 'Storm', '1007', '92', '85.7', 
      'by57b760-e1b4-41c7-a6e1-000000000033', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-01', 'Storm', '1008', '50', '83.3', 
      'by57b760-e1b4-41c7-a6e1-000000000034', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-01', 'Clear', '1006', '25', '101.2', 
      'by57b760-e1b4-41c7-a6e1-000000000035', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-01', 'Clouds', '1014', '55', '76.0', 
      'by57b760-e1b4-41c7-a6e1-000000000036', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-01', 'Fog', '1012', '68', '71.4', 
      'by57b760-e1b4-41c7-a6e1-000000000037', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-01', 'Clear', '1016', '28', '88.0', 
      'by57b760-e1b4-41c7-a6e1-000000000038', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-01', 'Clear', '1010', '60', '86.6', 
      'by57b760-e1b4-41c7-a6e1-000000000039', '2025-07-01', 'SystemSeeder', '2025-07-01'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-01', 'Clear', '1023', '40', '58.7', 
      'by57b760-e1b4-41c7-a6e1-000000000040', '2025-07-01', 'SystemSeeder', '2025-07-01');
");

            migrationBuilder.Sql(@"
 INSERT INTO Forecast (
     City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
     Pressure, Humidity, Temperature,
     UniqueId, Created, CreatedBy, LastModified
     ) VALUES
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-02', 'Humidity', '1012', '85', '82.5', 
      'gy52b760-e1b4-41c7-a6e1-000000000021', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-02', 'Clouds', '1011', '50', '79.8', 
      'gy52b760-e1b4-41c7-a6e1-000000000022', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-02', 'Clear', '1013', '45', '80.1', 
      'gy52b760-e1b4-41c7-a6e1-000000000023', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-02', 'Rain', '1009', '70', '67.2', 
      'gy52b760-e1b4-41c7-a6e1-000000000024', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-02', 'Clear', '1015', '20', '96.3', 
      'gy52b760-e1b4-41c7-a6e1-000000000025', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-02', 'Storm', '1005', '90', '73.0', 
      'gy52b760-e1b4-41c7-a6e1-000000000026', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-02', 'Wind', '1020', '40', '68.9', 
      'gy52b760-e1b4-41c7-a6e1-000000000027', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-02', 'Clouds', '1012', '60', '70.6', 
      'gy52b760-e1b4-41c7-a6e1-000000000028', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-02', 'Storm', '1006', '80', '74.3', 
      'gy52b760-e1b4-41c7-a6e1-000000000029', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-02', 'Hot', '1011', '65', '91.4', 
      'gy52b760-e1b4-41c7-a6e1-000000000030', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-02', 'Wind', '1021', '30', '60.1', 
      'gy52b760-e1b4-41c7-a6e1-000000000031', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-02', 'Hot', '1010', '88', '89.9', 
      'gy52b760-e1b4-41c7-a6e1-000000000032', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-02', 'Storm', '1007', '92', '85.7', 
      'gy52b760-e1b4-41c7-a6e1-000000000033', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-02', 'Storm', '1008', '50', '83.3', 
      'gy52b760-e1b4-41c7-a6e1-000000000034', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-02', 'Clear', '1006', '25', '101.2', 
      'gy52b760-e1b4-41c7-a6e1-000000000035', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-02', 'Clouds', '1014', '55', '76.0', 
      'gy52b760-e1b4-41c7-a6e1-000000000036', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-02', 'Fog', '1012', '68', '71.4', 
      'gy52b760-e1b4-41c7-a6e1-000000000037', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-02', 'Clear', '1016', '28', '88.0', 
      'gy52b760-e1b4-41c7-a6e1-000000000038', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-02', 'Clear', '1010', '60', '86.6', 
      'gy52b760-e1b4-41c7-a6e1-000000000039', '2025-07-02', 'SystemSeeder', '2025-07-02'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-02', 'Clear', '1023', '40', '58.7', 
      'gy52b760-e1b4-41c7-a6e1-000000000040', '2025-07-02', 'SystemSeeder', '2025-07-02');
");

            migrationBuilder.Sql(@"
 INSERT INTO Forecast (
     City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
     Pressure, Humidity, Temperature,
     UniqueId, Created, CreatedBy, LastModified
     ) VALUES
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-03', 'Humidity', '1012', '85', '82.5', 
      'nb92b860-e1b4-41c7-a6e1-000000000021', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-03', 'Clouds', '1011', '50', '79.8', 
      'nb92b860-e1b4-41c7-a6e1-000000000022', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-03', 'Clear', '1013', '45', '80.1', 
      'nb92b860-e1b4-41c7-a6e1-000000000023', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-03', 'Rain', '1009', '70', '67.2', 
      'nb92b860-e1b4-41c7-a6e1-000000000024', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-03', 'Clear', '1015', '20', '96.3', 
      'nb92b860-e1b4-41c7-a6e1-000000000025', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-03', 'Storm', '1005', '90', '73.0', 
      'nb92b860-e1b4-41c7-a6e1-000000000026', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-03', 'Wind', '1020', '40', '68.9', 
      'nb92b860-e1b4-41c7-a6e1-000000000027', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-03', 'Clouds', '1012', '60', '70.6', 
      'nb92b860-e1b4-41c7-a6e1-000000000028', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-03', 'Storm', '1006', '80', '74.3', 
      'nb92b860-e1b4-41c7-a6e1-000000000029', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-03', 'Hot', '1011', '65', '91.4', 
      'nb92b860-e1b4-41c7-a6e1-000000000030', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-03', 'Wind', '1021', '30', '60.1', 
      'nb92b860-e1b4-41c7-a6e1-000000000031', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-03', 'Hot', '1010', '88', '89.9', 
      'nb92b860-e1b4-41c7-a6e1-000000000032', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-03', 'Storm', '1007', '92', '85.7', 
      'nb92b860-e1b4-41c7-a6e1-000000000033', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-03', 'Storm', '1008', '50', '83.3', 
      'nb92b860-e1b4-41c7-a6e1-000000000034', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-03', 'Clear', '1006', '25', '101.2', 
      'nb92b860-e1b4-41c7-a6e1-000000000035', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-03', 'Clouds', '1014', '55', '76.0', 
      'nb92b860-e1b4-41c7-a6e1-000000000036', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-03', 'Fog', '1012', '68', '71.4', 
      'nb92b860-e1b4-41c7-a6e1-000000000037', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-03', 'Clear', '1016', '28', '88.0', 
      'nb92b860-e1b4-41c7-a6e1-000000000038', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-03', 'Clear', '1010', '60', '86.6', 
      'nb92b860-e1b4-41c7-a6e1-000000000039', '2025-07-03', 'SystemSeeder', '2025-07-03'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-03', 'Clear', '1023', '40', '58.7', 
      'nb92b860-e1b4-41c7-a6e1-000000000040', '2025-07-03', 'SystemSeeder', '2025-07-03');
");

            migrationBuilder.Sql(@"
 INSERT INTO Forecast (
     City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
     Pressure, Humidity, Temperature,
     UniqueId, Created, CreatedBy, LastModified
     ) VALUES
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-04', 'Humidity', '1012', '85', '82.5', 
      'cv87w860-e1b4-41c7-a6e1-000000000021', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-04', 'Clouds', '1011', '50', '79.8', 
      'cv87w860-e1b4-41c7-a6e1-000000000022', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-04', 'Clear', '1013', '45', '80.1', 
      'cv87w860-e1b4-41c7-a6e1-000000000023', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-04', 'Rain', '1009', '70', '67.2', 
      'cv87w860-e1b4-41c7-a6e1-000000000024', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-04', 'Clear', '1015', '20', '96.3', 
      'cv87w860-e1b4-41c7-a6e1-000000000025', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-04', 'Storm', '1005', '90', '73.0', 
      'cv87w860-e1b4-41c7-a6e1-000000000026', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-04', 'Wind', '1020', '40', '68.9', 
      'cv87w860-e1b4-41c7-a6e1-000000000027', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-04', 'Clouds', '1012', '60', '70.6', 
      'cv87w860-e1b4-41c7-a6e1-000000000028', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-04', 'Storm', '1006', '80', '74.3', 
      'cv87w860-e1b4-41c7-a6e1-000000000029', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-04', 'Hot', '1011', '65', '91.4', 
      'cv87w860-e1b4-41c7-a6e1-000000000030', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-04', 'Wind', '1021', '30', '60.1', 
      'cv87w860-e1b4-41c7-a6e1-000000000031', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-04', 'Hot', '1010', '88', '89.9', 
      'cv87w860-e1b4-41c7-a6e1-000000000032', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-04', 'Storm', '1007', '92', '85.7', 
      'cv87w860-e1b4-41c7-a6e1-000000000033', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-04', 'Storm', '1008', '50', '83.3', 
      'cv87w860-e1b4-41c7-a6e1-000000000034', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-04', 'Clear', '1006', '25', '101.2', 
      'cv87w860-e1b4-41c7-a6e1-000000000035', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-04', 'Clouds', '1014', '55', '76.0', 
      'cv87w860-e1b4-41c7-a6e1-000000000036', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-04', 'Fog', '1012', '68', '71.4', 
      'cv87w860-e1b4-41c7-a6e1-000000000037', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-04', 'Clear', '1016', '28', '88.0', 
      'cv87w860-e1b4-41c7-a6e1-000000000038', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-04', 'Clear', '1010', '60', '86.6', 
      'cv87w860-e1b4-41c7-a6e1-000000000039', '2025-07-04', 'SystemSeeder', '2025-07-04'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-04', 'Clear', '1023', '40', '58.7', 
      'cv87w860-e1b4-41c7-a6e1-000000000040', '2025-07-04', 'SystemSeeder', '2025-07-04');
");

            migrationBuilder.Sql(@"
 INSERT INTO Forecast (
     City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
     Pressure, Humidity, Temperature,
     UniqueId, Created, CreatedBy, LastModified
     ) VALUES
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-05', 'Humidity', '1012', '85', '82.5', 
      'jk97w430-e1b4-41c7-a6e1-000000000021', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-05', 'Clouds', '1011', '50', '79.8', 
      'jk97w430-e1b4-41c7-a6e1-000000000022', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-05', 'Clear', '1013', '45', '80.1', 
      'jk97w430-e1b4-41c7-a6e1-000000000023', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-05', 'Rain', '1009', '70', '67.2', 
      'jk97w430-e1b4-41c7-a6e1-000000000024', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-05', 'Clear', '1015', '20', '96.3', 
      'jk97w430-e1b4-41c7-a6e1-000000000025', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-05', 'Storm', '1005', '90', '73.0', 
      'jk97w430-e1b4-41c7-a6e1-000000000026', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-05', 'Wind', '1020', '40', '68.9', 
      'jk97w430-e1b4-41c7-a6e1-000000000027', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-05', 'Clouds', '1012', '60', '70.6', 
      'jk97w430-e1b4-41c7-a6e1-000000000028', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-05', 'Storm', '1006', '80', '74.3', 
      'jk97w430-e1b4-41c7-a6e1-000000000029', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-05', 'Hot', '1011', '65', '91.4', 
      'jk97w430-e1b4-41c7-a6e1-000000000030', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-05', 'Wind', '1021', '30', '60.1', 
      'jk97w430-e1b4-41c7-a6e1-000000000031', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-05', 'Hot', '1010', '88', '89.9', 
      'jk97w430-e1b4-41c7-a6e1-000000000032', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-05', 'Storm', '1007', '92', '85.7', 
      'jk97w430-e1b4-41c7-a6e1-000000000033', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-05', 'Storm', '1008', '50', '83.3', 
      'jk97w430-e1b4-41c7-a6e1-000000000034', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-05', 'Clear', '1006', '25', '101.2', 
      'jk97w430-e1b4-41c7-a6e1-000000000035', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-05', 'Clouds', '1014', '55', '76.0', 
      'jk97w430-e1b4-41c7-a6e1-000000000036', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-05', 'Fog', '1012', '68', '71.4', 
      'jk97w430-e1b4-41c7-a6e1-000000000037', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-05', 'Clear', '1016', '28', '88.0', 
      'jk97w430-e1b4-41c7-a6e1-000000000038', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-05', 'Clear', '1010', '60', '86.6', 
      'jk97w430-e1b4-41c7-a6e1-000000000039', '2025-07-05', 'SystemSeeder', '2025-07-05'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-05', 'Clear', '1023', '40', '58.7', 
      'jk97w430-e1b4-41c7-a6e1-000000000040', '2025-07-05', 'SystemSeeder', '2025-07-05');
");

            migrationBuilder.Sql(@"
 INSERT INTO Forecast (
     City, ForecastName, ForecastDescription, ForecastDate, ForecastMain, 
     Pressure, Humidity, Temperature,
     UniqueId, Created, CreatedBy, LastModified
     ) VALUES
     ('Nashville', 'Humid Morning', 'High humidity with a chance of showers', '2025-07-06', 'Humidity', '1012', '85', '82.5', 
      'tva7w430-e1b4-41c7-a6e1-000000000021', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Indianapolis', 'Partly Sunny', 'Clouds early, clearing by noon', '2025-07-06', 'Clouds', '1011', '50', '79.8', 
      'tva7w430-e1b4-41c7-a6e1-000000000022', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Columbus', 'Clear', 'Clear skies and sunny', '2025-07-06', 'Clear', '1013', '45', '80.1', 
      'tva7w430-e1b4-41c7-a6e1-000000000023', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Baltimore', 'Showers', 'Light rain throughout the day', '2025-07-06', 'Rain', '1009', '70', '67.2', 
      'tva7w430-e1b4-41c7-a6e1-000000000024', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Salt Lake City', 'Sunny', 'Hot and sunny all day', '2025-07-06', 'Clear', '1015', '20', '96.3', 
      'tva7w430-e1b4-41c7-a6e1-000000000025', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Kansas City', 'Rainstorm', 'Heavy rain in the morning', '2025-07-06', 'Storm', '1005', '90', '73.0', 
      'tva7w430-e1b4-41c7-a6e1-000000000026', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Cincinnati', 'Cool Breeze', 'Cool morning with breeze', '2025-07-06', 'Wind', '1020', '40', '68.9', 
      'tva7w430-e1b4-41c7-a6e1-000000000027', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Cleveland', 'Overcast Skies', 'Cloudy and mild', '2025-07-06', 'Clouds', '1012', '60', '70.6', 
      'tva7w430-e1b4-41c7-a6e1-000000000028', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Pittsburgh', 'Thunderstorm Alert', 'Scattered thunderstorms', '2025-07-06', 'Storm', '1006', '80', '74.3', 
      'tva7w430-e1b4-41c7-a6e1-000000000029', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('St. Louis', 'Hot Afternoon', 'Hot temperatures in the afternoon', '2025-07-06', 'Hot', '1011', '65', '91.4', 
      'tva7w430-e1b4-41c7-a6e1-000000000030', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Milwaukee', 'Chilly Winds', 'Cool and breezy day', '2025-07-06', 'Wind', '1021', '30', '60.1', 
      'tva7w430-e1b4-41c7-a6e1-000000000031', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Tampa', 'Humid Heat', 'Hot with high humidity', '2025-07-06', 'Hot', '1010', '88', '89.9', 
      'tva7w430-e1b4-41c7-a6e1-000000000032', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('New Orleans', 'Stormy Weather', 'Heavy rain and lightning', '2025-07-06', 'Storm', '1007', '92', '85.7', 
      'tva7w430-e1b4-41c7-a6e1-000000000033', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Oklahoma City', 'Dry Thunder', 'Thunderstorms with little rain', '2025-07-06', 'Storm', '1008', '50', '83.3', 
      'tva7w430-e1b4-41c7-a6e1-000000000034', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Albuquerque', 'Clear and Hot', 'Dry, sunny, and hot', '2025-07-06', 'Clear', '1006', '25', '101.2', 
      'tva7w430-e1b4-41c7-a6e1-000000000035', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Raleigh', 'Mild and Cloudy', 'Overcast with light breeze', '2025-07-06', 'Clouds', '1014', '55', '76.0', 
      'tva7w430-e1b4-41c7-a6e1-000000000036', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Richmond', 'Morning Mist', 'Light fog clearing by mid-morning', '2025-07-06', 'Fog', '1012', '68', '71.4', 
      'tva7w430-e1b4-41c7-a6e1-000000000037', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Boise', 'Warm and Dry', 'Dry and sunny conditions', '2025-07-06', 'Clear', '1016', '28', '88.0', 
      'tva7w430-e1b4-41c7-a6e1-000000000038', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Honolulu', 'Tropical Sun', 'Hot and sunny with breeze', '2025-07-06', 'Clear', '1010', '60', '86.6', 
      'tva7w430-e1b4-41c7-a6e1-000000000039', '2025-07-06', 'SystemSeeder', '2025-07-06'),
     ('Anchorage', 'Cool and Clear', 'Cool with sunshine', '2025-07-06', 'Clear', '1023', '40', '58.7', 
      'tva7w430-e1b4-41c7-a6e1-000000000040', '2025-07-06', 'SystemSeeder', '2025-07-06');
");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM Forecast
                WHERE CreatedBy = 'SystemSeeder' AND Created in ('2025-07-01','2025-07-02','2025-07-03','2025-07-04','2025-07-05','2025-07-01');
            ");
        }
    }
}

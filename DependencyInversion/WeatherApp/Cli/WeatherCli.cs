using WeatherApp.Interfaces;

namespace WeatherApp.Cli;

public class WeatherCli(IWeatherProvider provider)
{
  private readonly IWeatherProvider _provider = provider;

  public async Task RunAsync(string[] args)
  {
    // TODO: Create validator for the args
    // OPTIONAL: Separate the arguments
    var coordinates = (args.Length > 0 ? args[0] : "-16.54649,-68.058805").Split(',');
    // TODO: Validate that coordinates are valid coordinates
    var latitude = coordinates[0];
    var longitude = coordinates[1];
    var temperature = await _provider.GetTodayAsync(latitude, longitude);

    Console.WriteLine($"Today weather is: {temperature} Celsius");
  }
}
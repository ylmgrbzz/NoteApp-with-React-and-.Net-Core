namespace NoteApp
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureCs { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    internal int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}


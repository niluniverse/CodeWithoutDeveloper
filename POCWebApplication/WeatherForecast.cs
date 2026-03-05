namespace POCWebApplication
{
    /// <summary>
    /// Weather forecast data model
    /// </summary>
    public class WeatherForecast
    {
        /// <summary>
        /// Date of the forecast
        /// </summary>
        public DateOnly Date { get; set; }

        /// <summary>
        /// Temperature in Celsius
        /// </summary>
        public int TemperatureC { get; set; }

        /// <summary>
        /// Temperature in Fahrenheit (calculated)
        /// </summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        /// <summary>
        /// Weather summary description
        /// </summary>
        public string? Summary { get; set; }
    }
}
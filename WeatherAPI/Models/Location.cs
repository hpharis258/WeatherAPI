namespace WeatherAPI.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Current_Temperature { get; set; }
        public string Maximum_Temperature { get; set; }
        public string Minimum_Temperature { get; set; }
        public string Pressure { get; set; }
        public string Humidityl { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set;}

    }
}

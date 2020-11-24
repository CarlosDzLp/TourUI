using System;
namespace TourUI.Models
{
    public class CityModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public bool Wifi { get; set; }
        public bool Umbrella { get; set; }
        public bool Worked { get; set; }
        public bool Restaurant { get; set; }
        public string PathImage { get; set; }
        public string Hours { get; set; }
    }
}

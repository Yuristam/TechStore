namespace TechStore.Domain.Entities
{
    public class TV
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public float ScreenSize { get; set; } // 15,6 inch
        public string Display { get; set; } // IPS
        public string ScreenResolutionType { get; set; } //full HD
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

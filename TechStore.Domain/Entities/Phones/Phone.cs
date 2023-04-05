namespace TechStore.Domain.Entities.Phones
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public float ScreenSize { get; set; } // 15,6 inch
        public string Display { get; set; } // IPS
        public int RAM { get; set; } // 16 GB
        public int ROM { get; set; } // 128 GB
        public float Camera { get; set; } // 12 Mpixels
        public int Battery { get; set; } // 5000mAh 
        public string Processor { get; set; } // snapdragon
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

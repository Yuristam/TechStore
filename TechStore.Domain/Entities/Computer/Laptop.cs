namespace TechStore.Domain.Entities
{
    public class Laptop
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public float ScreenSize { get; set; } // 15,6 inch
        public string PanelType { get; set; } // IPS
        public string ScreenResolutionType { get; set; } //full HD
        public int Brightness { get; set; } //300 nit
        public int RefreshRate { get; set; } // 75 hz
        public bool Camera { get; set; }
        public int ROM { get; set; } // HDD SSD
        public string Color { get; set; }
        public int PowerConsumption { get; set; }// 2000W
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; }
    }
}

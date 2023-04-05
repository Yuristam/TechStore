namespace TechStore.Domain.Entities
{
    public class Monitor
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public float ScreenSize { get; set; } // 15,6 inch
        public string PanelType { get; set; } // IPS
        public string ScreenResolutionType { get; set; } //full HD
        public int Brightness { get; set; } //300 nit
        public int ResponseTime { get; set; } // 5 ms
        public int RefreshRate { get; set; } // 75 hz
        public bool FrontCamera { get; set; } // false
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

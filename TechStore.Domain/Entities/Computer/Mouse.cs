namespace TechStore.Domain.Entities.Computer
{
    public class Mouse
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public int ButtonsCount { get; set; } // 3
        public int PollingRate { get; set; } // 1000 Hz
        public int Resolution { get; set; } // 12800 DPI
        public bool IsWireless { get; set; } //true
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public decimal Price { get; set; } // 15,00 $
    }
}

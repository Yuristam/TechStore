namespace TechStore.Domain.Entities.Computer
{
    public class Keyboard
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public bool IsWireless { get; set; } //true
        public bool IsIlluminated { get; set; } // true
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public decimal Price { get; set; } // 15,00 $
    }
}

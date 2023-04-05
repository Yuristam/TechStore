namespace TechStore.Domain.Entities.Phones
{
    public class Headphone
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public bool IsWireless { get; set; } //true
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public decimal Price { get; set; } // 15,00 $
    }
}

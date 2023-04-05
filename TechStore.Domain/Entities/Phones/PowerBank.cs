namespace TechStore.Domain.Entities.Phones
{
    public class PowerBank
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public int Capacity { get; set; } // 33000 mAh
        public int OutputPort { get; set; } // 3
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public decimal Price { get; set; } // 15,00 $
    }
}

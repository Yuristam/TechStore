namespace TechStore.Domain.Entities.HomeAppliances
{
    public class AC
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public int PowerConsumption { get; set; }// 2000W
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

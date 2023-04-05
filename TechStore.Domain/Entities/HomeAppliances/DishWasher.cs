namespace TechStore.Domain.Entities.HomeAppliances
{
    public class DishWasher
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public string Color { get; set; } // Silver Inox
        public string ControlType { get; set; } //button
        public int PowerConsumption { get; set; }// 2000W
        public float WaterConsumption { get; set; } // 9.5 L
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

namespace TechStore.Domain.Entities
{
    public class PC
    {
        public int Id { get; set; }
        public string BuildName { get; set; }
        public int PowerConsumption { get; set; }// 2000W
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public decimal Price { get; set; }
    }
}

﻿namespace TechStore.Domain.Entities.HomeAppliances
{
    public class VacuumCleaner
    {
        public int Id { get; set; }
        public string Model { get; set; } // Samsung LED...
        public string Color { get; set; } // platinum grey
        public int PowerConsumption { get; set; }// 2000W
        public int SoundLevel { get; set; } // 85 dB
        public string Brand { get; set; } // Sony
        public DateTime ManufactureDate { get; set; } // 12/1/2002
        public int WarranityDate { get; set; } //3 years
        public decimal Price { get; set; } // 15,00 $
    }
}

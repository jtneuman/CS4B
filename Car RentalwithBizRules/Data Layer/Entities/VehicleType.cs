using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Data_Layer.Entities
{
    public class VehicleType : IVehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BasePricePerKm { get; set; }
        public double BasePricePerDay { get; set; }
        public double DayTariff { get; set; }
        public double KmTariff { get; set; }
    }
}

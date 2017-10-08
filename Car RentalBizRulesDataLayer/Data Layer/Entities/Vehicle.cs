using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Data_Layer.Entities
{
    public class Vehicle : IVehicle
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public double BasePricePerKm { get; set; }
        public double BasePricePerDay { get; set; }
        public double DayTariff { get; set; }
        public double KmTariff { get; set; }
        public string RegistrationNumber { get; set; }
        public double Meter { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(IVehicle vehicle)
        {
            Id = vehicle.Id;
            TypeId = vehicle.TypeId;
            BasePricePerKm = vehicle.BasePricePerKm;
            BasePricePerDay = vehicle.BasePricePerDay;
            DayTariff = vehicle.DayTariff;
            KmTariff = vehicle.KmTariff;
            RegistrationNumber = vehicle.RegistrationNumber;
            Meter = vehicle.Meter;
        }
    }
}

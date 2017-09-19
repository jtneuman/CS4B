using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Interfaces
{
    public interface IVehicle
    {
        int Id { get; set; }
        int TypeId { get; set; }
        double BasePricePerKm { get; set; }
        double BasePricePerDay { get; set; }
        double DayTariff { get; set; }
        double KmTariff { get; set; }
        string RegistrationNumber { get; set; }
        double Meter { get; set; }

    }
}

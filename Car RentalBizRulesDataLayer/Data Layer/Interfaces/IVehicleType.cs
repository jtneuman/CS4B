using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Interfaces
{
    public interface IVehicleType
    {
        int Id { get; set; }
        string Name { get; set; }
        double BasePricePerKm { get; set; }
        double BasePricePerDay { get; set; }
        double DayTariff { get; set; }
        double KmTariff { get; set; }

    }
}

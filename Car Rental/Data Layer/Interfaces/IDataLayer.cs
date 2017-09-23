using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Interfaces
{
    public interface IDataLayer : IRentalBase
    {
        #region Helper Methods

        int RentalDuration(DateTime rented, DateTime returned);
        double CalculatePrice(IVehicle vehicle, double returnedMeterSetting, int duration);

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Enums;

namespace Data_Layer.Interfaces
{
    public interface IRentalBase
    {

        #region Action Methods

        bool RentVehicle(int vehicleId, int customerId, DateTime timeOfRental);

        #endregion

        #region Fetch Methods

        IEnumerable<ICustomer> GetCustomers();
        IEnumerable<IVehicle> GetVehicles(VehicleStatus status);
        IVehicleType GetVehicleType(int vehicleTypeId);

        #endregion
    }
}

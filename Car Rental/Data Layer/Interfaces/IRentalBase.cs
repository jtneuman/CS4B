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
        double ReturnVehicle(int bookingId, double meter,
            DateTime returned);

        bool AddVehicle(IVehicle vehicle);

        #endregion

        #region Fetch Methods

        IEnumerable<ICustomer> GetCustomers();
        IEnumerable<IBooking> GetBookings();
        IEnumerable<IVehicle> GetVehicles(VehicleStatus status);
        IEnumerable<IVehicleType> GetVehicleTypes();
        IVehicleType GetVehicleType(int vehicleTypeId);

        #endregion
    }
}

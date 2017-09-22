using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Data_Layer.Enums;
using Data_Layer.Interfaces;

namespace Business_Layer.Classes
{
    public class BookingProcessor : IBookingProcessor
    {
        #region Properties

        public IDataLayer DataLayer { get; private set; }

        #endregion

        #region Constructor

        public BookingProcessor(IDataLayer dataLayer)
        {
            DataLayer = dataLayer;
        }

        #endregion

        #region Action Methods

        public bool RentVehicle(int vehicleId, int customerId, DateTime timeOfRental)
        {
            try
            {
                return DataLayer.RentVehicle(vehicleId, customerId, DateTime.Now);
            }
            catch (Exception)
            {

                throw;
            };
        }

        #endregion

        #region Fetch Methods

        public IEnumerable<ICustomer> GetCustomers()
        {
            try
            {
                return DataLayer.GetCustomers();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<IVehicle> GetVehicles(VehicleStatus status)
        {
            try
            {
                return DataLayer.GetVehicles(status);
            }
            catch
            {

                throw;
            };
        }

        public IVehicleType GetVehicleType(int vehicleTypeId)
        {
            try
            {
                return DataLayer.GetVehicleType(vehicleTypeId);
            }
            catch
            {

                throw;
            };
        }



        #endregion

        #region Helper Methods


        #endregion
    }
}

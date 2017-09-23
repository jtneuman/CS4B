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

        public double ReturnVehicle(int bookingId, double meter, DateTime returned)
        {
            try
            {
                return DataLayer.ReturnVehicle(bookingId, meter, returned);
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

        public IEnumerable<IBooking> GetBookings()
        {
            try
            {
                return DataLayer.GetBookings();
            }
            catch (Exception)
            {

                throw;
            };
        }

        public IBooking GetBooking(int vehicleId)
        {
            try
            {
                return (from b in DataLayer.GetBookings()
                        where b.VehicleId.Equals(vehicleId) &&
                              b.Returned.Equals(DateTime.MinValue)
                        select b).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            };
        }



        #endregion

        #region Helper Methods


        #endregion
    }
}

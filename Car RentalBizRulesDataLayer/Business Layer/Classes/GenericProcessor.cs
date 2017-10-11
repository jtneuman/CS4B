using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Data_Layer.Enums;
using Data_Layer.Exceptions;
using Data_Layer.Interfaces;

namespace Business_Layer.Classes
{
    public class GenericProcessor : IGenericProcessor
    {
        #region Properties

        public IGenericDataLayer DataLayer { get; private set; }

        #endregion

        #region Constructor

        public GenericProcessor(IGenericDataLayer dataLayer)
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

        public bool AddVehicle(IVehicle vehicle)
        {
            try
            {
                if (vehicle.Id > 0 || vehicle.Meter < 0 || 
                    vehicle.RegistrationNumber.Equals(String.Empty) ||
                    vehicle.TypeId < 1)
                {
                    throw new VehicleException(vehicle.Id,
                        "The vehicle has erroneous data.");
                }
                return DataLayer.AddVehicle(vehicle);
                // or 
                // DataLayer.AddVehicle(vehicle);
                // return
            }
            catch (Exception)
            {

                throw;
            };
        } //End AddVehicle method

        public void AddCustomer(ICustomer customer)
        {
            try
            {
                // Business logic to confirm that the customer does not yet exist.
                if (customer.Id > 0) throw new CustomerException(customer.Id, "The customer has erroneous data.");
                if (CustomerExist(customer.SocialSecurityNumber))
                    throw new CustomerException(customer.Id,
                        "The customer already exists.");
                DataLayer.AddCustomer(customer);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Fetch Methods

        //public IEnumerable<ICustomer> GetCustomers()
        //{
        //    try
        //    {
        //        return DataLayer.GetCustomers();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

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

        //public IEnumerable<IBooking> GetBookings()
        //{
        //    try
        //    {
        //        return DataLayer.GetBookings();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    };
        //}

        public IBooking GetBooking(int vehicleId)
        {
            try
            {
                return (from b in DataLayer.Get<IBooking>()
                        where b.VehicleId.Equals(vehicleId) &&
                              b.Returned.Equals(DateTime.MinValue)
                        select b).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            };
        }

        //public IEnumerable<IVehicleType> GetVehicleTypes()
        //{
        //    try
        //    {
        //        return DataLayer.GetVehicleTypes();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}




        #endregion

        #region Helper Methods

        public bool CustomerExist(string socialSecurityNumber)
        {
            var social = (from c in DataLayer.Get<ICustomer>()
                          where c.SocialSecurityNumber.Equals(
                              socialSecurityNumber)
                          select c).Count();
            return social > 0;
        }

        #endregion

        #region Generic Methods

        public IEnumerable<T> Get<T>()
        {
            return DataLayer.Get<T>();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;
using Data_Layer.Data_Source;
using Data_Layer.Enums;
using Data_Layer.Entities;

namespace Data_Layer.Data_Layers
{
    public class CollectionDataLayer : IDataLayer
    {

        public CollectionDataLayer()
        {
            new TestData().Seed();
        }


        #region Action Methods

        public bool RentVehicle(int vehicleId, int customerId, DateTime timeOfRental)
        {
            try
            {
                var bookingId = TestData.Bookings.Max(b => b.Id) + 1;

                TestData.Bookings.Add(new Booking()
                {
                    Id = bookingId,
                    CustomerId = customerId,
                    Rented = timeOfRental,
                    VehicleId = vehicleId
                });
                return true;
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
            return TestData.Customers;
        }

        public IEnumerable<IVehicle> GetVehicles(VehicleStatus status)
        {
            switch (status)
            {
                case VehicleStatus.All:
                    return TestData.Vehicles;
                case VehicleStatus.Booked:
                    return from c in TestData.Vehicles
                           join b in TestData.Bookings on c.Id equals b.VehicleId
                           where b.Returned.Equals(DateTime.MinValue)
                           select c;
                case VehicleStatus.Available:
                    return from c in TestData.Vehicles
                           where GetVehicles(VehicleStatus.Booked)
                           .Count(b => b.Id.Equals(c.Id)).Equals(0)
                           select c;
                default:
                    break;
            }

            return new List<IVehicle>();
        }

        public IVehicleType GetVehicleType(int vehicleTypeId)
        {
            return TestData.VehicleTypes.FirstOrDefault(
                vt => vt.Id.Equals(vehicleTypeId));
        }



        #endregion

        #region Helper Methods



        #endregion



    }
}

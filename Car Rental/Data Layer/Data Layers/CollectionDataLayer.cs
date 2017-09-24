using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;
using Data_Layer.Data_Source;
using Data_Layer.Enums;
using Data_Layer.Entities;
using Data_Layer.Exceptions;

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

        public double ReturnVehicle(int bookingId, double meter, DateTime returned)
        {
            try
            {
                var booking = TestData.Bookings.FirstOrDefault(b => b.Id.Equals(bookingId) && b.Returned.Equals(DateTime.MinValue));

                // Throw exception if something wron with the booking object
                if (booking == null) throw new BookingException(bookingId);
                if (booking.VehicleId == 0 || booking.VehicleId < 1) throw new BookingException(bookingId);
                if (booking.Rented.Date == DateTime.MinValue) throw new BookingException(bookingId);
                if (booking.Rented.Date > returned) throw new BookingException(bookingId, "Rental date is greater than the return date.");
                if (returned == DateTime.MinValue) throw new BookingException(bookingId, "The car is still rented out.");

                var vehicle = TestData.Vehicles.FirstOrDefault(v => v.Id.Equals(booking.VehicleId));

                // Throw exception it there is something wrong with the vehicle object.
                if (vehicle == null) throw new VehicleException(vehicle.Id, "The vehicle is not rented out.");
                if (vehicle.Meter > meter) throw new VehicleException(vehicle.Id, "The meter setting is lower than the current meter setting.");

                // calculate the cost.
                var duration = RentalDuration(booking.Rented, returned);
                var cost = CalculatePrice(vehicle, meter, duration);
                booking.Returned = returned;
                booking.Cost = cost;
                vehicle.Meter = meter;

                return cost;

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
                vehicle.Id = TestData.Vehicles.Max(b => b.Id) + 1;
                // adding to vehicles coll in testdata class
                TestData.Vehicles.Add(vehicle);
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

        public IEnumerable<IBooking> GetBookings()
        {
                return TestData.Bookings;
        }

        public IEnumerable<IVehicleType> GetVehicleTypes()
        {
            return TestData.VehicleTypes;
        }

        #endregion

        #region Helper Methods

        public int RentalDuration(DateTime rented, DateTime returned)
        {
            TimeSpan time = returned - rented;

            if (time.Days == 0 && returned.TimeOfDay - rented.TimeOfDay > TimeSpan.MinValue)
            {
                return 1;
            }
            else
                return time.Days;

        }

        public double CalculatePrice(IVehicle vehicle, double returnedMeterSetting, int duration)
        {
            return vehicle.BasePricePerDay * duration * vehicle.DayTariff + vehicle.BasePricePerKm * (returnedMeterSetting - vehicle.Meter) * vehicle.KmTariff;
        }






        #endregion



    }
}

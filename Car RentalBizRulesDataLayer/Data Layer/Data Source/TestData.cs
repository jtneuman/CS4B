using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;
using Data_Layer.Entities;

namespace Data_Layer.Data_Source
{
    class TestData
    {
        #region Collections

        internal static List<IVehicleType> VehicleTypes = new List<IVehicleType>();
        internal static List<ICustomer> Customers = new List<ICustomer>();
        internal static List<IVehicle> Vehicles = new List<IVehicle>();
        internal static List<IBooking> Bookings = new List<IBooking>();

        #endregion

        #region Methods

        internal void Seed()
        {

            // VehicleType Collection
            VehicleTypes.Add(new VehicleType()
            {
                Id = 1,
                Name = "Sedan",
                BasePricePerDay = 100,
                BasePricePerKm = 0,
                DayTariff = 1,
                KmTariff = 1
            });
            VehicleTypes.Add(new VehicleType()
            {
                Id = 2,
                Name = "Combi",
                BasePricePerDay = 200,
                BasePricePerKm = 0.5,
                DayTariff = 1.3,
                KmTariff = 1
            });
            VehicleTypes.Add(new VehicleType()
            {
                Id = 3,
                Name = "Van",
                BasePricePerDay = 300,
                BasePricePerKm = 0.5,
                DayTariff = 1.5,
                KmTariff = 1.5
            });

            // Vehicle Collection
            Vehicles.Add(new Vehicle()
            {
                Id = 1,
                TypeId = 1,
                BasePricePerDay = 100,
                BasePricePerKm = 0,
                DayTariff = 1,
                KmTariff = 1,
                RegistrationNumber = "FGH123",
                Meter = 10000
            });
            Vehicles.Add(new Vehicle()
            {
                Id = 2,
                TypeId = 2,
                BasePricePerDay = 200,
                BasePricePerKm = 0.5,
                DayTariff = 1.3,
                KmTariff = 1,
                RegistrationNumber = "ABC123",
                Meter = 20000
            });
            Vehicles.Add(new Vehicle()
            {
                Id = 3,
                TypeId = 3,
                BasePricePerDay = 100,
                BasePricePerKm = 0.5,
                DayTariff = 1.5,
                KmTariff = 1.5,
                RegistrationNumber = "DCE123",
                Meter = 30000
            });

            // Customer Collection Data
            Customers.Add(new Customer()
            {
                Id = 1, FirstName = "Carl",
                LastName = "Raintree",
                SocialSecurityNumber = "1232454"
            });
            Customers.Add(new Customer()
            {
                Id = 2,
                FirstName = "Lisa",
                LastName = "Montgomery",
                SocialSecurityNumber = "95654123"
            });

            // Booking Collection Data
            Bookings.Add(new Booking()
            {
                Id = 1,
                VehicleId = 2,
                Rented = DateTime.Now,
                Returned = DateTime.Now.AddDays(1),
                Cost = 500,
                CustomerId = 2
            });
            Bookings.Add(new Booking()
            {
                Id = 2,
                VehicleId = 2,
                Rented = DateTime.Now,
                Returned = DateTime.Now.AddDays(1),
                Cost = 400,
                CustomerId = 1
            });

        }

        #endregion

    }
}

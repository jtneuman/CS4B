using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Classes
{
    class ListViewBooking
    {
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public double Cost { get; set; }
        public string Customer { get; set; }
        public string RegistrationNumber { get; set; }
        public string VehicleType { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }

        public string[] ToArray()
        {
            return new string[]
            {
                BookingId.ToString(),
                RegistrationNumber,
                VehicleType,
                Customer,
                Cost.ToString(),
                Rented.ToString(),
                Returned == DateTime.MinValue ?
                    String.Empty : Returned.ToString()
        };
        }
    }
}

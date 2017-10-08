using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Data_Layer.Entities
{
    public class Booking : IBooking
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }
        public double Cost { get; set; }
    }
}

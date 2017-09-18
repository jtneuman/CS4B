using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Interfaces
{
    public interface IBooking
    {
        int Id { get; set; }
        int VehicleId { get; set; }
        int CustomerId { get; set; }
        DateTime Rented { get; set; }
        DateTime Returned { get; set; }
        double Cost { get; set; }
    }
}

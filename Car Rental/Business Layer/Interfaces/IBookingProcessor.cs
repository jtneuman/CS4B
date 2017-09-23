using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Business_Layer.Interfaces
{
    public interface IBookingProcessor : IRentalBase
    {
        IDataLayer DataLayer { get; }

        IBooking GetBooking(int vehicleId);
    }
}

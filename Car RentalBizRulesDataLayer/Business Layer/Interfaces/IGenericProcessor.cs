using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Business_Layer.Interfaces
{
    public interface IGenericProcessor : IGenericBase
    {
        IGenericDataLayer DataLayer { get; }

        IBooking GetBooking(int vehicleId);
        bool CustomerExist(string socialSecurityNumber);
    }
}

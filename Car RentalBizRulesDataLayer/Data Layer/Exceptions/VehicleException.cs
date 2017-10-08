using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class VehicleException : KeyNotFoundException
    {
        public int Id { get; private set; }

        public VehicleException(int id, string message =
            "The given vehicle Id does not ext") : base(message)
        {
            Id = id;
        }
    }
}

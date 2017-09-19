using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Data_Layer.Entities
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(IVehicle vehicle) : base(vehicle)
        {

        }
    }
}

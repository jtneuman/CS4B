using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollections.Interfaces;

namespace GenericCollections.Classes
{
    class Car : IVehicle
    {

        public string RegNo { get; set; }
        public string Model { get; set; }

    }
}

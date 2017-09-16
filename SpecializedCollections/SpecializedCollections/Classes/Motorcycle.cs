using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecializedCollections.Interfaces;

namespace SpecializedCollections.Classes
{
    class Motorcycle : IRegisterable
    {
        public string RegNo { get; set; }
        public string Model { get; set; }

        public bool IsRegistered { get; set; }

        public string DisplayValue
        {
            get
            {
                return String.Format("{0} : {1} : {2}",
                    RegNo, Model, IsRegistered.ToString());
            }
        }

        public Motorcycle(string regNo, string model, bool isRegistered)
        {
            RegNo = regNo;
            Model = model;
            IsRegistered = isRegistered;
        }

        // Default constructor to use IRegisterable
        public Motorcycle()
        {

        }

    }
}

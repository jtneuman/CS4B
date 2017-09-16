using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecializedCollections.Interfaces;

namespace SpecializedCollections.Classes
{
    public class Car : IRegisterable
    {

        public string RegNo { get; set; }
        public string Model { get; set; }

        public bool IsRegistered { get; set; }
        public string DisplayValue {
            get {
                return String.Format("{0} : {1} : {2}",
                    RegNo, Model, IsRegistered.ToString());
            }
        }
    }
}

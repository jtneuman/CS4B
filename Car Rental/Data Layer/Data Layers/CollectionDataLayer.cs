using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;
using Data_Layer.Data_Source;

namespace Data_Layer.Data_Layers
{
    public class CollectionDataLayer : IDataLayer
    {

        public CollectionDataLayer()
        {
            new TestData().Seed();
        }
    }
}

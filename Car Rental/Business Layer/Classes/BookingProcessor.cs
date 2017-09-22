using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Interfaces;
using Data_Layer.Interfaces;

namespace Business_Layer.Classes
{
    public class BookingProcessor : IBookingProcessor
    {
        #region Properties

        public IDataLayer DataLayer { get; private set; }

        #endregion

        #region Constructor

        public BookingProcessor(IDataLayer dataLayer)
        {
            DataLayer = dataLayer;
        }

        #endregion

        #region Action Methods



        #endregion

        #region Fetch Methods

        public IEnumerable<ICustomer> GetCustomers()
        {
            try
            {
                return DataLayer.GetCustomers();
            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

        #region Helper Methods


        #endregion
    }
}

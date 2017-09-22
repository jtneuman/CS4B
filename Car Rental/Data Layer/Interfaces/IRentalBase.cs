using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Interfaces
{
    public interface IRentalBase
    {

        #region Action Methods



        #endregion

        #region Fetch Methods

        IEnumerable<ICustomer> GetCustomers();

        #endregion
    }
}

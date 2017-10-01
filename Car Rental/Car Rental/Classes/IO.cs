using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer.Interfaces;

namespace Car_Rental.Classes
{
    class IO
    {
        public static bool WriteToFile (string path, IEnumerable<ICustomer> customers)
        {
            try
            {
                var file = new FileStream(path, FileMode.Create, FileAccess.Write);
                var writer = new StreamWriter(file);
                foreach (var customer in customers)
                {
                    writer.WriteLine(String.Format("{0}\t{1}\t{2}\t{3}", customer.Id, customer.SocialSecurityNumber, customer.LastName, customer.FirstName));

                    writer.Close();
                    file.Close();
                }
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}

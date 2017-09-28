using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadandWrite.Classes
{

    enum DataFormat{
        Binary,
        Text
    }

    class IO
    {
        static bool WriteToFile(string path, DataFormat dataFormat, object data)
        {
            try
            {
                var file = new FileStream(path, FileMode.Create, FileAccess.Write);

                if (dataFormat.Equals(DataFormat.Binary)) { }
                else if (dataFormat.Equals(DataFormat.Text)) { }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }// end WriteToFile method

        static bool ReadFile(string path, DataFormat dataFormat, out object data)
        {
            data = null;

            try
            {
                var file = new FileStream(path, FileMode.Open,
                    FileAccess.Read);
                if (dataFormat.Equals(DataFormat.Binary)) { }
                else if (dataFormat.Equals(DataFormat.Text)) { }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

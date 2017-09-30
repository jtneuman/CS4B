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
        public static bool WriteToFile(string path, DataFormat dataFormat, object data)
        {
            try
            {
                var file = new FileStream(path, FileMode.Create, FileAccess.Write);

                if (dataFormat.Equals(DataFormat.Binary)) {
                    #region Binary Writer

                    var writer = new BinaryWriter(file);

                    foreach (byte b in data as byte[])
                    {
                        writer.Write(b);
                        writer.Close();
                        file.Close();
                    }

                    #endregion
                }
                else if (dataFormat.Equals(DataFormat.Text)) {
                    #region Stream Writer

                    StreamWriter writer = new StreamWriter(file);
                    writer.WriteLine(data);
                    writer.Close();
                    file.Close();

                    #endregion
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }// end WriteToFile method

        public static bool ReadFile(string path, DataFormat dataFormat, out object data)
        {
            data = null;

            try
            {
                var file = new FileStream(path, FileMode.Open,
                    FileAccess.Read);
                if (dataFormat.Equals(DataFormat.Binary)) {
                    #region Binary Reader

                    var reader = new BinaryReader(file);
                    int length = (int)reader.BaseStream.Length;

                    //read all data into an array
                    byte[] binaryData = new byte[length];
                    reader.Read(binaryData, 0, length);

                    reader.Close();
                    file.Close();

                    data = binaryData;

                    #endregion
                }
                else if (dataFormat.Equals(DataFormat.Text)) {
                    #region Stream Reader

                    StreamReader reader = new StreamReader(file);
                    data = reader.ReadToEnd();
                    reader.Close();
                    file.Close();

                    #endregion
                }


                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

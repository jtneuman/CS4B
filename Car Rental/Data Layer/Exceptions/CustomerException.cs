using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class CustomerException : KeyNotFoundException
    {
        public int Id { get; private set; }

        public CustomerException(int id, string message =
            "The given customer Id does not ext") : base(message)
        {
            Id = id;
        }
    }
}

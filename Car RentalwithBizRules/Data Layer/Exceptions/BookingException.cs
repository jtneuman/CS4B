using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Exceptions
{
    public class BookingException : KeyNotFoundException
    {
        public int Id { get; private set; }

        public BookingException(int id, string message =
            "The given booking Id does not ext") : base(message)
        {
            Id = id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Classes
{
    class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get {
            return String.Format("{0} {1}", LastName, FirstName);} }

        public Customer(Guid id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(string firstName, string lastname)
            : this(Guid.NewGuid(), firstName, lastname)
        {
        }


    }
}

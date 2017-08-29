using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Chapter10.ExerciseA.Interfaces;

namespace Exercises.Chapter10.ExerciseA.Classes
{
    public class Employee : IPerson, IEmployee
    {
        #region IEmployee Implementation
        public int EmployeeId { get; private set; }

        public string Department { get; set; }
        public double Salary { get; set; }
        #endregion

        #region Iperson Implementation
        public int PersonId { get; private set; }

        public string Name { get; set; }
        public DateTime Born { get; set; }

        public int Age()
        {
            return DateTime.Now.AddYears(-Born.Year).Year;
        }
        #endregion
        public Employee(int employeeId, int personId, string department,
            double salary, string name, DateTime born)
        {
            EmployeeId = employeeId;
            PersonId = personId;
            Department = department;
            Salary = salary;
            Name = name;
            Born = born;
        }
    }
}

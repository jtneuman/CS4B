using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter10.ExerciseA.Interfaces
{
    interface IEmployee
    {
        int EmployeeId { get; }
        string Department { get; set; }
        double Salary { get; set; }
    }
}

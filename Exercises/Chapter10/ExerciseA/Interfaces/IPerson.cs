using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter10.ExerciseA.Interfaces
{
    interface IPerson
    {
        // Property definitions
        int PersonId { get; }
        string Name { get; set; }
        DateTime Born { get; set; }

        // Methods
        int Age();
    }
}

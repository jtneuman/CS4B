using Exercises.Chapter10.ExerciseA.Classes;
using Exercises.Chapter10.ExerciseA.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises
{
    public partial class Form1 : Form
    {
        Employee emp1 = new Employee(1, 2, "Science", 123000,
            "Carl Carlton", new DateTime(1982, 10, 5));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbnEmployeeClass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnEmployeeClass_Click(object sender, EventArgs e)
        {
            // Can use all members from both interfaces
            txtResult.Text = String.Format("(Employee)\n" +
                "{0}, {1}, {2}, {3}\n" + "{4}, {5}, {6}",
                emp1.PersonId, emp1.Name, emp1.Born.Year, emp1.Age(),
                emp1.EmployeeId, emp1.Department, emp1.Salary);
        }

        private void rbnIPersonInterface_Click(object sender, EventArgs e)
        {
            // Cast as IPerson
            // Can only use members from the IPerson interface
            var person = (IPerson)emp1;
            txtResult.Text = String.Format("(IPerson)\n{0},{1}, {2}, {03}",
                person.PersonId, person.Name, person.Born.Year, person.Age());
        }

        private void rbnIEmployeeInterface_Click(object sender, EventArgs e)
        {
            // Cast as IEmployee
            // Can only use members from the IEmployee interface
            var employee = emp1 as IEmployee;
            txtResult.Text = String.Format("(IEmployee)\n{0}, {1}, {2}",
                employee.EmployeeId, employee.Department, employee.Salary);
        }
    }
}

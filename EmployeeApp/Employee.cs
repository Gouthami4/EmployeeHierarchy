/******************************************************************************
 * Filename    = Employee.cs
 *
 * Author      = [Your Name]
 *
 * Product     = EmployeeHierarchy
 * 
 * Project     = EmployeeApp
 *
 * Description = Defines the base Employee class and derived classes Manager 
 *               and Developer for representing different types of employees.
 *****************************************************************************/

namespace EmployeeHierarchy
{
    /// <summary>
    /// Base class for all employee types containing common properties and behaviors.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets the unique identifier for the employee.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the name of the employee.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the salary of the employee.
        /// </summary>
        public decimal Salary { get; }

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        /// <param name="id">The unique identifier for the employee.</param>
        /// <param name="name">The name of the employee.</param>
        /// <param name="salary">The salary of the employee.</param>
        public Employee(string id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        /// <summary>
        /// Provides a description of the employee.
        /// </summary>
        /// <returns>A string describing the employee.</returns>
        public virtual string Describe() =>
            $"{Name} ({Id}) earning {Salary:F2}";
    }
}
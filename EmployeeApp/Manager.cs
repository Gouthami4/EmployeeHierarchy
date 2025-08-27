/******************************************************************************
 * Filename    = Manager.cs
 *
 * Author      = Gouthami
 *
 * Product     = EmployeeHierarchy
 * 
 * Project     = EmployeeApp
 *
 * Description = Defines the Manager class that extends Employee with 
 *               management-specific properties and behaviors.
 *****************************************************************************/

namespace EmployeeHierarchy
{
    /// <summary>
    /// Represents a Manager employee with team management responsibilities.
    /// </summary>
    public class Manager : Employee
    {
        /// <summary>
        /// Gets the size of the team managed by this manager.
        /// </summary>
        public int TeamSize { get; }

        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        /// <param name="id">The unique identifier for the manager.</param>
        /// <param name="name">The name of the manager.</param>
        /// <param name="salary">The salary of the manager.</param>
        /// <param name="teamSize">The size of the team managed by this manager.</param>
        public Manager(string id, string name, decimal salary, int teamSize)
            : base(id, name, salary)
        {
            TeamSize = teamSize;
        }

        /// <summary>
        /// Describes the manager's project management responsibilities.
        /// </summary>
        /// <returns>A string describing the manager's responsibilities.</returns>
        public string ManageProject() =>
            $"{Name} manages a team of {TeamSize}.";

        /// <summary>
        /// Provides a description of the manager including team size.
        /// </summary>
        /// <returns>A string describing the manager.</returns>
        public override string Describe() =>
            base.Describe() + $" [Manager of {TeamSize}]";
    }
}
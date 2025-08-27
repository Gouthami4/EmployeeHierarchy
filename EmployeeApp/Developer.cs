/******************************************************************************
 * Filename    = Developer.cs
 *
 * Author      = [Your Name]
 *
 * Product     = EmployeeHierarchy
 * 
 * Project     = EmployeeApp
 *
 * Description = Defines the Developer class that extends Employee with 
 *               development-specific properties and behaviors.
 *****************************************************************************/

namespace EmployeeHierarchy
{
    /// <summary>
    /// Represents a Developer employee with coding responsibilities.
    /// </summary>
    public class Developer : Employee
    {
        /// <summary>
        /// Gets the primary programming language of the developer.
        /// </summary>
        public string Language { get; }

        /// <summary>
        /// Initializes a new instance of the Developer class.
        /// </summary>
        /// <param name="id">The unique identifier for the developer.</param>
        /// <param name="name">The name of the developer.</param>
        /// <param name="salary">The salary of the developer.</param>
        /// <param name="language">The primary programming language of the developer.</param>
        public Developer(string id, string name, decimal salary, string language)
            : base(id, name, salary)
        {
            Language = language;
        }

        /// <summary>
        /// Describes the developer's coding activities.
        /// </summary>
        /// <returns>A string describing the developer's coding activities.</returns>
        public string WriteCode() =>
            $"{Name} writes code in {Language}.";

        /// <summary>
        /// Provides a description of the developer including programming language.
        /// </summary>
        /// <returns>A string describing the developer.</returns>
        public override string Describe() =>
            base.Describe() + $" [Developer in {Language}]";
    }
}
/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Gouthami
 *
 * Product     = EmployeeHierarchy
 * 
 * Project     = EmployeeApp
 *
 * Description = Main application that demonstrates the employee hierarchy 
 *               by creating and interacting with Manager and Developer instances.
 *****************************************************************************/

using System;
using EmployeeHierarchy;

namespace EmployeeApp
{
    /// <summary>
    /// Main application class for demonstrating the employee hierarchy.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// </summary>
        static void Main()
        {
            // Create instances of Manager and Developer
            var manager = new Manager("M01", "Siddharth", 90000m, 5);
            var developer = new Developer("D01", "Rishitha", 60000m, "C#");

            // Display information about the manager
            Console.WriteLine(manager.Describe());
            Console.WriteLine(manager.ManageProject());

            // Display information about the developer
            Console.WriteLine(developer.Describe());
            Console.WriteLine(developer.WriteCode());
        }
    }
}
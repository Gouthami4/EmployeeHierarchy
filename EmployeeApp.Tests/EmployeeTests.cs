/******************************************************************************
 * Filename    = EmployeeTests.cs
 *
 * Author      = Gouthami
 *
 * Product     = EmployeeHierarchy
 * 
 * Project     = EmployeeApp.Tests
 *
 * Description = Contains unit tests for verifying the Employee hierarchy 
 *               functionality using MSTest framework.
 *****************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeHierarchy;

namespace EmployeeApp.Tests
{
    /// <summary>
    /// Test class for verifying Employee hierarchy functionality.
    /// </summary>
    [TestClass]
    public class EmployeeTests
    {
        /// <summary>
        /// Verifies that Manager inherits from Employee and implements Manager-specific behavior.
        /// </summary>
        [TestMethod]
        public void Manager_ShouldInheritFromEmployee_AndAddBehavior()
        {
            var manager = new Manager("M01", "Siddharth", 90000m, 5);

            // Verify inheritance
            Assert.IsInstanceOfType(manager, typeof(Employee));

            // Verify Manager-specific behavior
            Assert.AreEqual("Siddharth manages a team of 5.", manager.ManageProject());
            StringAssert.Contains(manager.Describe(), "Manager");
        }

        /// <summary>
        /// Verifies that Developer inherits from Employee and implements Developer-specific behavior.
        /// </summary>
        [TestMethod]
        public void Developer_ShouldInheritFromEmployee_AndAddBehavior()
        {
            var developer = new Developer("D01", "Rishitha", 60000m, "C#");

            // Verify inheritance
            Assert.IsInstanceOfType(developer, typeof(Employee));

            // Verify Developer-specific behavior
            Assert.AreEqual("Rishitha writes code in C#.", developer.WriteCode());
            StringAssert.Contains(developer.Describe(), "Developer");
        }

        /// <summary>
        /// Verifies that Employee properties are correctly set and accessible.
        /// </summary>
        [TestMethod]
        public void Employee_Properties_ShouldBeCorrectlySet()
        {
            // Arrange
            var employee = new Employee("E01", "John", 50000m);

            // Assert
            Assert.AreEqual("E01", employee.Id);
            Assert.AreEqual("John", employee.Name);
            Assert.AreEqual(50000m, employee.Salary);
            Assert.AreEqual("John (E01) earning 50000.00", employee.Describe());
        }

        /// <summary>
        /// Verifies that Manager with zero team size is handled correctly.
        /// </summary>
        [TestMethod]
        public void Manager_WithZeroTeamSize_ShouldHandleCorrectly()
        {
            // Arrange
            var manager = new Manager("M02", "Alice", 80000m, 0);

            // Assert
            Assert.AreEqual("Alice manages a team of 0.", manager.ManageProject());
            StringAssert.Contains(manager.Describe(), "Manager of 0");
        }
    }
}
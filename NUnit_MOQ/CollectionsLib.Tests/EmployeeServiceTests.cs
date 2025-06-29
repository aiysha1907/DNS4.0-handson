using NUnit.Framework;
using CollectionsLib;
using System.Linq;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        private EmployeeService _service;

        [SetUp]
        public void Setup()
        {
            _service = new EmployeeService();
        }

        [Test]
        public void GetEmployees_ShouldNotContainNulls()
        {
            var employees = _service.GetEmployees();
            Assert.That(employees, Is.All.Not.Null);
        }

        [Test]
        public void GetEmployees_ShouldContainEmployeeWithId100()
        {
            var employees = _service.GetEmployees();
            Assert.That(employees.Any(e => e.Id == 100), Is.True);
        }

        [Test]
        public void GetEmployees_ShouldHaveUniqueEmployees()
        {
            var employees = _service.GetEmployees();
            var distinct = employees.Distinct().ToList();
            Assert.That(employees.Count, Is.EqualTo(distinct.Count));
        }

        [Test]
        public void GetEmployeesAndPreviousYearEmployees_ShouldBeEqual()
        {
            var list1 = _service.GetEmployees();
            var list2 = _service.GetEmployeesWhoJoinedInPreviousYears();
            CollectionAssert.AreEqual(list1, list2);
        }
    }
}

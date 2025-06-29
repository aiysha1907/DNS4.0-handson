using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class LeapYearCheckerTests
    {
        private LeapYearChecker _checker;

        [SetUp]
        public void Setup()
        {
            _checker = new LeapYearChecker();
        }

        [TestCase(2024, ExpectedResult = 1)]
        [TestCase(2000, ExpectedResult = 1)]
        [TestCase(1900, ExpectedResult = 0)]
        [TestCase(2023, ExpectedResult = 0)]
        [TestCase(1700, ExpectedResult = -1)]
        [TestCase(10000, ExpectedResult = -1)]
        public int IsLeapYear_YearInput_ReturnsExpectedResult(int year)
        {
            return _checker.IsLeapYear(year);
        }
    }
}

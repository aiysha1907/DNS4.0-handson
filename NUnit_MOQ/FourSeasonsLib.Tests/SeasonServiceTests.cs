using NUnit.Framework;
using FourSeasonsLib;
using System.Collections;

namespace FourSeasonsLib.Tests
{
    [TestFixture]
    public class SeasonServiceTests
    {
        private SeasonService _service;

        [SetUp]
        public void Setup()
        {
            _service = new SeasonService();
        }

        public static IEnumerable TestData
        {
            get
            {
                yield return new TestCaseData("February").Returns("Spring");
                yield return new TestCaseData("March").Returns("Spring");
                yield return new TestCaseData("April").Returns("Summer");
                yield return new TestCaseData("May").Returns("Summer");
                yield return new TestCaseData("June").Returns("Summer");
                yield return new TestCaseData("July").Returns("Monsoon");
                yield return new TestCaseData("August").Returns("Monsoon");
                yield return new TestCaseData("September").Returns("Monsoon");
                yield return new TestCaseData("October").Returns("Autumn");
                yield return new TestCaseData("November").Returns("Autumn");
                yield return new TestCaseData("December").Returns("Winter");
                yield return new TestCaseData("January").Returns("Winter");
                yield return new TestCaseData("Blah").Returns("Invalid");
            }
        }

        [Test, TestCaseSource(nameof(TestData))]
        public string GetSeason_MonthInput_ReturnsCorrectSeason(string month)
        {
            return _service.GetSeason(month);
        }
    }
}

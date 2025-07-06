using NUnit.Framework;
using UtilLib;

namespace UtilLib.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser _parser;

        [SetUp]
        public void SetUp()
        {
            _parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_HttpUrl_ReturnsHostName()
        {
            string result = _parser.ParseHostName("http://example.com/page");
            Assert.That(result, Is.EqualTo("example.com"));
        }

        [Test]
        public void ParseHostName_HttpsUrl_ReturnsHostName()
        {
            string result = _parser.ParseHostName("https://openai.com/chat");
            Assert.That(result, Is.EqualTo("openai.com"));
        }

        [Test]
        public void ParseHostName_InvalidUrl_ReturnsInvalid()
        {
            string result = _parser.ParseHostName("ftp://abc.com");
            Assert.That(result, Is.EqualTo("Invalid URL"));
        }
    }
}

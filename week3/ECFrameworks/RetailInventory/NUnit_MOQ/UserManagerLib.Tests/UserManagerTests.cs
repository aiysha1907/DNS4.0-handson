using NUnit.Framework;
using UserManagerLib;
using System;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private UserManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new UserManager();
        }

        [Test]
        public void CreateUser_ValidPan_ReturnsSuccessMessage()
        {
            var result = _manager.CreateUser("ABCDE1234Z");
            Assert.That(result, Is.EqualTo("User Created Successfully"));
        }

        [Test]
        public void CreateUser_NullPan_ThrowsNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => _manager.CreateUser(null));
        }

        [Test]
        public void CreateUser_EmptyPan_ThrowsNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => _manager.CreateUser(""));
        }

        [Test]
        public void CreateUser_InvalidLengthPan_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() => _manager.CreateUser("ABCD123"));
        }
    }
}

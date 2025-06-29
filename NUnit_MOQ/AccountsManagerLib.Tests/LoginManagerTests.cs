using NUnit.Framework;
using AccountsManagerLib;
using System;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class LoginManagerTests
    {
        private LoginManager _loginManager;

        [SetUp]
        public void Setup()
        {
            _loginManager = new LoginManager();
        }

        [Test]
        public void Login_ValidCredentials_ReturnsWelcomeMessage()
        {
            var result = _loginManager.Login("user_11", "secret@user11");
            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsErrorMessage()
        {
            var result = _loginManager.Login("user_11", "wrongpass");
            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _loginManager.Login("", "password"));
            Assert.That(ex.Message, Does.Contain("User ID"));
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _loginManager.Login("user_22", ""));
            Assert.That(ex.Message, Does.Contain("User ID"));
        }
    }
}

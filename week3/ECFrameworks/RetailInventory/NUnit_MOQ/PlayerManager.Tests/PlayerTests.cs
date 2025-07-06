using NUnit.Framework;
using Moq;
using PlayersManagerLib;
using System;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> _mockMapper;

        [SetUp]
        public void Init()
        {
            _mockMapper = new Mock<IPlayerMapper>();
        }

        [Test]
        public void RegisterNewPlayer_ShouldReturnPlayer_WhenNameDoesNotExist()
        {
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);

            var player = Player.RegisterNewPlayer("Rohit", _mockMapper.Object);

            Assert.AreEqual("Rohit", player.Name);
            Assert.AreEqual("India", player.Country);
            Assert.AreEqual(23, player.Age);
        }

        [Test]
        public void RegisterNewPlayer_ShouldThrowException_WhenNameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer(""));
        }

        [Test]
        public void RegisterNewPlayer_ShouldThrowException_WhenNameAlreadyExists()
        {
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(true);

            Assert.Throws<ArgumentException>(() => Player.RegisterNewPlayer("Rohit", _mockMapper.Object));
        }
    }
}

using NUnit.Framework;
using Moq;
using MagicFilesLib;
using System.Collections.Generic;
using System.Linq;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _mockExplorer;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _mockExplorer = new Mock<IDirectoryExplorer>();
            _mockExplorer.Setup(m => m.GetFiles(It.IsAny<string>()))
                .Returns(new List<string> { _file1, _file2 });
        }

        [Test]
        public void GetFiles_ShouldReturnMockedFiles()
        {
            var result = _mockExplorer.Object.GetFiles("dummyPath");

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.Contains(_file1, result.ToList());
        }
    }
}

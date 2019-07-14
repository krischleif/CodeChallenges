using FileScanner.Services.Interfaces;
using FileScanner.Services;
using NUnit.Framework;
using System.IO;

namespace Tests
{
    public class Tests
    {
        IFileScannerService service;
        string directory;
        [SetUp]
        public void Setup()
        {
            service = new FileScannerService();
            directory = $"{Directory.GetCurrentDirectory()}/TestDirectory";
        }

        [Test]
        public void GetNumberOfFilesTest()
        {
            var res = service.GetNumberOfFiles(directory);

            Assert.AreEqual(2, res);
        }

        [Test]
        public void GetNumberOfDirectoriesTest()
        {
            var res = service.GetNumberOfDirectories(directory);

            Assert.AreEqual(1, res);
        }

        [Test]
        public void GetFileSizeTotalTest()
        {
            var res = service.GetFileSizeTotal(directory);

            Assert.AreEqual(1726, res);
        }

        [Test]
        public void GetAverageFileSizeTest()
        {
            var res = service.GetAverageFileSize(directory);

            Assert.AreEqual(863, res);
        }
    }
}
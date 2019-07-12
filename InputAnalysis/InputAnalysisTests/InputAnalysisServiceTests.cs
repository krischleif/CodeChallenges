using InputAnalysis.Services;
using InputAnalysis.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class InputAnalysisServiceTests
    {
        IInputAnalysisService service;
        [SetUp]
        public void Setup()
        {
            service = new InputAnalysisService();
        }


        [Test]
        public void GetSumOfAllNumbers_HappyPath()
        {
            var res = service.GetSumOfAllNumbers();

            Assert.AreEqual(16.2, res);
        }


        [Test]
        public void GetCountOfAllNumbers_HappyPath()
        {
            var res = service.GetCountOfAllNumbers();

            Assert.AreEqual(3, res);
        }


        [Test]
        public void ContainsString_HappyPath()
        {
            var res = service.ContainsString("foo");

            Assert.IsTrue(res);
        }


        [Test]
        public void ContainsSubString_HappyPath()
        {
            var res = service.ContainsSubString("fox");

            Assert.IsTrue(res);
        }
    }
}
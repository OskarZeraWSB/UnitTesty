using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        [TestMethod]
        public void IN_1_ReturnFalse()
        {
            var result = _primeService.IsPrime(-1);
            Assert.IsFalse(result, $"-1 should not be prime");
        }
        [TestMethod]
        public void IN0_ReturnFalse()
        {
            var result = _primeService.IsPrime(0);
            Assert.IsFalse(result, $"0 should not be prime");
        }
        [TestMethod]
        public void IN1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, $"1 should not be prime");
        }
        [TestMethod]
        public void IN2_ReturnTrue()
        {
            var result = _primeService.IsPrime(2);
            Assert.IsTrue(result, $"2 should be prime");
        }
        [TestMethod]
        public void IN3_ReturnTrue()
        {
            var result = _primeService.IsPrime(3);
            Assert.IsTrue(result, $"3 should be prime");
        }
        [TestMethod]
        public void IN4_ReturnTrue()
        {
            var result = _primeService.IsPrime(4);
            Assert.IsFalse(result, $"4 should be prime");
        }
        [TestMethod]
        public void IN5_ReturnTrue()
        {
            var result = _primeService.IsPrime(5);
            Assert.IsTrue(result, $"5 should be prime");
        }
        [TestMethod]
        public void IN6_ReturnTrue()
        {
            var result = _primeService.IsPrime(6);
            Assert.IsFalse(result, $"6 should be prime");
        }
        [TestMethod]
        public void IN7_ReturnTrue()
        {
            var result = _primeService.IsPrime(7);
            Assert.IsTrue(result, $"7 should be prime");
        }
        [TestMethod]
        public void IN8_ReturnTrue()
        {
            var result = _primeService.IsPrime(8);
            Assert.IsFalse(result, $"8 should be prime");
        }
        [TestMethod]
        public void IN9_ReturnTrue()
        {
            var result = _primeService.IsPrime(9);
            Assert.IsFalse(result, $"9 should be prime");
        }
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void ValuesLessThan2_RETFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}

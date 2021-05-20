using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        PrimeService primeService = new PrimeService();

        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}
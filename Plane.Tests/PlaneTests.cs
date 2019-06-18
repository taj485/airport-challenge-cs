using NUnit.Framework;
using Plane;

namespace Plane.UnitTests
{
   [TestFixture]
   public class Plane
   {
       private readonly PrimeService _primeService;

       public PrimeService_IsPrimeShould()
       {
           _primeService = new PrimeService();
       }

       [Test]
       public void ReturnFalseGivenValueOf1()
       {
           var result = _primeService.IsPrime(1);

           Assert.IsFalse(result, “1 should not be prime”);
       }
   }
}
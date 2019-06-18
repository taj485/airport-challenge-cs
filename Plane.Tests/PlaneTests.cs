using NUnit.Framework;
using Airport;

namespace Airport.UnitTests
{
   [TestFixture]
   public class Plane_ReturnsInstanceOf
   {
       private readonly Plane _plane;

       public Plane_CanReturnInstanceOf()
       {
           _plane = new Plane();
       }

       [Test]
       public void ReturnsInstanceOf()
       {
           Assert.IsInstanceOf(typeof(Plane), _plane);
       }
   }
}
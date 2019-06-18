using NUnit.Framework;
using Airport;

namespace Airport.UnitTests
{
   [TestFixture]
   public class Terminal_ReturnsInstanceOf
   {
       private readonly Terminal _terminal; Terminal _terminal2; Plane _plane; 

       public Terminal_ReturnsInstanceOf()
       {
           _terminal = new Terminal(20);
           _plane = new Plane();
       }

       [Test]
       public void ReturnsInstanceOfTerminal()
       {
           Assert.IsInstanceOf(typeof(Terminal), _terminal);
       }

       [Test]
       public void ReturnsValueOfCapacity()
       {
           Assert.AreEqual(20, _terminal.Capacity);
       }

       [Test]
       public void HasADefaultCapacity()
       {
           _terminal2 = new Terminal();
           Assert.AreEqual(10, _terminal2.Capacity);
       }

       [Test]
       public void HasAHanger()
       {
           Assert.AreEqual(0, _terminal.Hanger.Count);
       }

       [Test]
       public void PlaneCanLandInHanger()
       {
           _terminal.Land(_plane);
           Assert.AreEqual(1, _terminal.Hanger.Count);
       }

       [Test]
       public void PlaneIsInHanger()
       {
           _terminal.Land(_plane);
           CollectionAssert.Contains(_terminal.Hanger, _plane);
       }

       [Test]
       public void CanRespondToLand()
       {
           var type =_terminal.GetType();
           Assert.IsTrue(type.GetMethod("Land") != null);
       }

   }
}
using NUnit.Framework;
using Airport;

namespace Airport.UnitTests
{
   [TestFixture]
   public class Terminal_ReturnsInstanceOf
   {
       private readonly Terminal _terminal; Terminal _terminal2; 

       public Terminal_ReturnsInstanceOf()
       {
           _terminal = new Terminal(20);
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
           Assert.IsEmpty(_terminal.Hanger);
       }

       [Test]
       public void CanRespondToLand()
       {
           var type =_terminal.GetType();
           Assert.IsTrue(type.GetMethod("Land") != null);
       }

    //    [Test]
    //    public void CanAddPlaneToHanger()
    //    {
    //     //    var type =_terminal.GetType();
    //     //    Assert.IsTrue(type.GetMethod("Land") != null);
    //    }

   }
}
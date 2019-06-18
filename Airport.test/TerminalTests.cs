using NUnit.Framework;
using Airport;

namespace Airport.UnitTests
{
   [TestFixture]
   public class Terminal_ReturnsInstanceOf
   {
       private readonly Terminal _terminal;

       public Terminal_ReturnsInstanceOf()
       {
           _terminal = new Terminal();
       }

       [Test]
       public void ReturnsInstanceOfTerminal()
       {
           Assert.IsInstanceOf(typeof(Terminal), _terminal);
       }
   }
}
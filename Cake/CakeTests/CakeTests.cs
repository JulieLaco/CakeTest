using Cake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTests
{
    [TestFixture]
    public class CakeTests
    {
        [Test]
        public void HelloTest()
        {
            Cake.Cake cake = new Cake.Cake();
            Assert.That(cake.Hello("Try the rainbow test the rainbow").Equals("Try the rainbow test the rainbow"));
        }
    }
}

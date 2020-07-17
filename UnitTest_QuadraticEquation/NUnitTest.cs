using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_QuadraticEquation
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void DiscriminantTestLessThanZero()
        {
            QuadraticEquation equation = new QuadraticEquation(5, 8, 12);
            string actualResult = equation.Discriminant();
            Assert.AreEqual("Рівняння немає коренів", actualResult);
        }

    }
}

using NUnit.Framework;
using QuadraticEquationProject;
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
        [Test]
        public void DiscriminantTestAIsEqualToZero()
        {
            QuadraticEquation equation = new QuadraticEquation(0, 2, 7);
            string actualResult = equation.Discriminant();
            Assert.AreEqual("Корені рівняння задані не вірно", actualResult);
        }
        [Test]
        public void DiscriminantTestIsZero()
        {
            QuadraticEquation equation = new QuadraticEquation(1, -6, 9);
            string actualResult = equation.Discriminant();
            Assert.AreEqual("x = 3", actualResult);
        }
        [Test]
        public void DiscriminantTestMoreThenZero()
        {
            QuadraticEquation equation = new QuadraticEquation(1, -8, 12);
            string actualResult = equation.Discriminant();
            Assert.AreEqual("x1 = 6, x2 = 2", actualResult);
        }
    }
}

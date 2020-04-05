using Challenge2.Entities;
using Challenge2.Repository;
using NUnit.Framework;
using System;
using static Challenge2.BL.Calculator;

namespace Tests
{
    public class AdditionTest
    {
        private IStrategy strategy;

       [SetUp]
        public void Setup()
        {
            strategy = GetOperation("+");
        }

        [Test]
        public void NormalOperation()
        {
            // Arrange
            var a = new Complex { Real = 2, Imaginary = -7 };
            var b = new Complex { Real = 4, Imaginary = 3 };
            
            // Act
            var result = strategy.Process(a, b);
            var comparation = new Complex { Real = 6, Imaginary= -4 };
            
            // Assert
            Assert.AreEqual($"{comparation.Real},{comparation.Imaginary}i", $"{result.Real},{result.Imaginary}i");
        }
        [Test]
        public void withDecimal()
        {
            var a = new Complex { Real = 200.2f, Imaginary = -758.30f };
            var b = new Complex { Real = 4200f, Imaginary = 350.20f };

            var row = strategy.Process(a, b);
            var result = DisplayResultOperation(row);

            Assert.AreEqual("4400.2-408.1i", result);
        }

        [Test]
        public void inputInZero()
        {
            var a = new Complex { Real = 0, Imaginary = 0 };
            var b = new Complex { Real = 0, Imaginary = 0 };

            var result = strategy.Process(a, b);
            var valid = DisplayResultOperation(result);

            Assert.IsTrue(valid=="0");
        }
    }
}
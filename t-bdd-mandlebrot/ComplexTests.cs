using NUnit.Framework;

namespace Mandlebrot
{
    [TestFixture]
    class TestContainer
    {
        static double imaginaryPart0 = 1.0;
        static double realPart0 = -1.0;
        static double imaginaryPart1 = -0.5;
        static double realPart1 = 0.5;
        Complex z0;
        Complex z1;

        [TestFixtureSetUp]
        public void setup_stuff()
        {
            z0 = new Complex(realPart0, imaginaryPart0);
            z1 = new Complex(realPart1, imaginaryPart1);
        }

        [Test]
        public void true_should_not_throw()
        {
            Assert.True(true);
        }

        [Test]
        public void complex_number_can_be_instantiated()
        {
            Assert.IsNotNull(z0);
        }

        [Test]
        public void complex_number_can_be_created_and_assigned()
        {
            Assert.AreEqual(z0.real, realPart0, "real part not matching literal");
            Assert.AreEqual(z0.imaginary, imaginaryPart0, "imaginary part not matching literal");
        }

        [Test]
        public void assignment_operator_works()
        {
            z1 = z0;
            Assert.AreEqual(z1.real, z0.real, "real part not matching literal");
            Assert.AreEqual(z1.imaginary, z0.imaginary, "imaginary part not matching literal");
        }

        [Test]
        public void addition_operator_works()
        {
            Assert.AreEqual(z0 + z1, new Complex(z0.real + z1.real, z0.imaginary + z1.imaginary), "sum didn't work");
        }

        [Test]
        public void multiplication_operator_works()
        {
            Assert.AreEqual(z0 * z1, new Complex((z0.real * z1.real) + (z0.imaginary * z1.imaginary), (z0.real * z1.imaginary) + (z0.imaginary * z1.real)), "product didn't work");
        }

        [Test]
        public void square_operator_works()
        {
            Assert.AreEqual(Complex.Square(z0), new Complex((z0.real * z0.real) + (z0.imaginary * z0.imaginary), (z0.real * z0.imaginary) + (z0.imaginary * z0.real)), "square didn't work");
        }

        [Test]
        public void subtraction_operator_works()
        {
            Assert.AreEqual(z0-z1, new Complex(z0.real - z1.real, z0.imaginary - z1.imaginary), "subtraction didn't work");
        }

        [Test]
        public void equals_equals_operator_works()
        {
            Assert.AreEqual((z0 == z0), (z0.real == z0.real && z0.imaginary == z0.imaginary), "== didn't work");
            Assert.AreEqual((z0 == z1), (z0.real == z1.real && z0.imaginary == z1.imaginary), "== didn't work");
        }

        [Test]
        public void Equals_operator_works()
        {
            Assert.False(z0.Equals(new System.DateTime()), "Equals didn't work");
            z1 = z0;
            Assert.True(z0.Equals(z1), "Equals didn't work");
        }

        [Test]
        public void not_equals_operator_works()
        {
            Assert.True(z0 != z1, "!= didn't work");
            Assert.False(z0 != z0, "!= didn't work");
        }
    }
}
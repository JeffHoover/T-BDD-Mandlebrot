namespace Mandlebrot
{
    public class Complex
    {
        public Complex (double a, double b)
        {
            real = a;
            imaginary = b;
        }

        public double imaginary;
        public double real;

        public static Complex Square (Complex z0)
        {
            return z0 * z0;
        }

        public static bool operator == (Complex c1, Complex c2)
        {
            return c1.real == c2.real && c1.imaginary == c2.imaginary;
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        override public bool Equals(object o0)
        {
            if (o0 is Complex)
            {
                return this == o0 as Complex;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.imaginary - c2.imaginary);
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public static Complex operator *(Complex z0, Complex z1)
        {
            return new Complex((z0.real * z1.real) + (z0.imaginary * z1.imaginary), (z0.real * z1.imaginary) + (z0.imaginary * z1.real));
        }
    }
}

using NBehave.Spec.NUnit;
using NBehave.Narrator.Framework;

namespace Mandlebrot
{
    /*
     nbehave-console.exe "C:\Documents and Settings\Jeff\My Documents\agile\katas\WindowsApplication2\WindowsApplication2\bin\Debug\WindowsApplication2.exe" /sf="C:\Documents and Settings\Jeff\My Documents\agile\katas\WindowsApplication2\WindowsApplication2\two_complex_numbers_are_added.feature"
     */
    [ActionSteps]
    public class complex_numbers_operations
    {
        Complex z0, z1, result;

        [Given("two complex numbers with components: real $r0, imaginary $i0 and real $r1, imaginary $i1")]
        void complc(double r0, double i0, double r1, double i1)
        {
            z0 = new Complex(r0, i0);
            z1 = new Complex(r1, i1);
        }

        [When("I add them")]
        public void complw()
        {
            result = z0 + z1;
        }

        [Then ("I should get a complex number with components: real $rr, imaginary $ii")]
        public void complt(double rr, double ii)
        {
            Extensions.ShouldEqual<Complex>(result, new Complex(rr,ii));
        }

        [When("I subtract the second from the first")]
        public void complw1()
        {
            result = z0 - z1;
        }

        [Then("I should get a complex number with components: real $rr, imaginary $ii")]
        public void complt1(double rr, double ii)
        {
            Extensions.ShouldEqual<Complex>(result, new Complex(rr, ii));
        }

        [When("I multiply them")]
        public void complw2()
        {
            result = z0 * z1;
        }

        [Then("I should get a complex number with components: real $rr, imaginary $ii")]
        public void complt2(double rr, double ii)
        {
            Extensions.ShouldEqual<double>(result.real, rr);
            Extensions.ShouldEqual<double>(result.imaginary, ii);
            //(z0.real * z1.real) + (z0.imaginary * z1.imaginary), (z0.real * z1.imaginary) + (z0.imaginary * z1.real)
            //Extensions.ShouldEqual<Complex>(result, new Complex(rr, ii));
        }

        //[Given("two complex numbers $c1 and $c2")]
        // Seem to only be able to specify primative types in .feature file.
        //public void g(Complex c1, Complex c2)
    }
}

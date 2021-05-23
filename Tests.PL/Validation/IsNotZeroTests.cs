using NUnit.Framework;
using PL.Validation;


namespace Tests.PL.Validation
{
    [TestFixture]
    public class IsNotZeroTests
    {
        [Test]
        public void IsNotZero_WithOne()
        {
            new IsNotZero().Validate(1);
        }
        [Test]
        public void IsNotZero_ValidationException()
        {
            Assert.Throws<ValidationException>(() => new IsNotZero().Validate(0));
        }
    }
}

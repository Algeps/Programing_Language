using NUnit.Framework;
using PL.Validation;

namespace Tests.PL.Validation
{
    [TestFixture]
    public class IsNotNaturalIntegerWithZeroTests
    {
        [Test]
        public void IsNotNaturalIntegerWithZero_WithZero()
        {
            new IsNotNaturalIntegerWithZero().Validate(0);
        }
        [Test]
        public void IsNotNaturalIntegerWithZero_ValidationException()
        {
            Assert.Throws<ValidationException>(() => new IsNotNaturalIntegerWithZero().Validate(-1));
        }
    }
}

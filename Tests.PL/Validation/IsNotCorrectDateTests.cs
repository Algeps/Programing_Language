using NUnit.Framework;
using PL.Validation;

namespace Tests.PL.Validation
{
    [TestFixture]
    class IsNotCorrectDateTests
    {
        [TestCase("01.01.2020", true)]
        [TestCase("32.10.2021", false)]
        [TestCase("19/08/2004", false)]
        public void IsNotCorrectDateFormat_Validation(string str, bool result)
        {
            if (result == true)
            {
                new IsNotCorrectDate().Validate(str);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new IsNotCorrectDate().Validate(str));
            }
        }
    }
}

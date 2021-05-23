using NUnit.Framework;
using PL.Validation;

namespace Tests.PL.Validation
{
    [TestFixture]
    public class StringValidationTests
    {
        [TestCase("Hello", "Hello", true)]
        [TestCase("Hello", "HelloWorld", false)]
        public void StringValidation_IsEquals(string str1, string str2, bool result)
        {
            if (result == true)
            {
                new StringValidation().IsEquals(str1, str2);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsEquals(str1, str2));
            }
        }

        [TestCase(" Hell o", "  hE lL o  ", true)]
        [TestCase("He llo", "   He ll o  W", false)]
        public void StringValidation_TrimToLowerAndReplaceAndIsEquals(string str1, string str2, bool result)
        {
            if (result == true)
            {
                new StringValidation().NormalizedStringsAndIsEquals(str1, str2);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsEquals(str1, str2));
            }
        }

        [TestCase("Hello", "olleH", true)]
        [TestCase("Hello", "HelloWorld", false)]
        public void StringValidation_IsPalindrome(string str1, string str2, bool result)
        {
            if (result == true)
            {
                new StringValidation().IsPalindrome(str1, str2);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsPalindrome("Hello", "olleHWorld"));
            }
        }

        [TestCase("nik17052001@yandex.ru", true)]
        [TestCase("nik17052001@", false)]
        public void StringValidation_IsEmail(string str, bool result)
        {
            if (result == true)
            {
                new StringValidation().IsEmail(str, 1);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsEmail(str, 1));
            }
        }


        [TestCase("89963841405", true)]
        [TestCase("r996384140wq", false)]
        public void StringValidation_IsPhoneNumber(string str, bool result)
        {
            if (result == true)
            {
                new StringValidation().IsPhoneNumber(str, 1);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsPhoneNumber(str, 1));
            }
        }

        [TestCase("256.168.0.1", true)]
        [TestCase("25616801", false)]
        public void StringValidation_IsIP(string str, bool result)
        {
            if (result == true)
            {
                new StringValidation().IsIP(str, 1);
            }
            else
            {
                Assert.Throws<ValidationException>(() => new StringValidation().IsIP(str, 1));
            }
        }
    }
}

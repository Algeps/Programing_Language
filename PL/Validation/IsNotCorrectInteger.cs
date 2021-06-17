using System;

namespace PL.Validation
{
    public class IsNotCorrectInteger : ISpecification<string>
    {
        public void Validate(string value)
        {
            if (!Int32.TryParse(value, out int iValue))
            {
                throw new ValidationException(string.Format("ERROR! Invalid format!   "));
            }
        }
    }
}

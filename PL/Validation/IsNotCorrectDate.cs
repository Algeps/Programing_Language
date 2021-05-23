using System;
using System.Globalization;
namespace PL.Validation
{
    public class IsNotCorrectDate : ISpecification<string>
    {
        public void Validate(string value)
        {
            DateTime date;
            if (!DateTime.TryParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                throw new ValidationException(string.Format("Incorrect format! Please, enter the date \"DD.MM.YYYY\": "));
            }
        }
    }
}

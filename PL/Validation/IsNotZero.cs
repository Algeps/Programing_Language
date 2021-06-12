

namespace PL.Validation
{
    public class IsNotZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value == 0)
            {
                throw new ValidationException("Enter only any integer other than zero! ");
            }
        }
    }
}

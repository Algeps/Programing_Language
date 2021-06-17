

namespace PL.Validation
{
    public class IsNotZero : ISpecification<int>
    {
        public void Validate(int value)
        {
            if (value == 0)
            {
                throw new ValidationException("Integer not must be equal zero! ");
            }
        }
    }
}

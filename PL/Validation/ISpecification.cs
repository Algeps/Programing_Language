using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Validation
{
    public interface ISpecification<T>
    {
        void Validate(T value);//должен передавать этому методу условие спецификации
    }
}

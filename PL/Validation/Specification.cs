using System;

namespace PL.Validation
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract void Validate(T value);

        public Specification<T> And(ISpecification<T> spec)
        {
            return new AndSpecification<T>(this, spec);
        }

        public Specification<T> Or(ISpecification<T> spec)
        {
            return new OrSpecification<T>(this, spec);
        }

        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public class AndSpecification<K> : Specification<K>
        {
            ISpecification<K> S1 = null;
            ISpecification<K> S2 = null;

            public AndSpecification(ISpecification<K> spec1, ISpecification<K> spec2) 
            {
                S1 = spec1;
                S2 = spec2;
            }

            public override void Validate(K value)
            {
                S1?.Validate(value);
                S2?.Validate(value);
            }
        }

        public class OrSpecification<K> : Specification<K>
        {
            ISpecification<K> S1 = null;
            ISpecification<K> S2 = null;

            public OrSpecification(ISpecification<K> spec1, ISpecification<K> spec2)
            {
                S1 = spec1;
                S2 = spec2;
            }

            public override void Validate(K value)
            {
                Exception ex1 = TryExecute(() => S1?.Validate(value));
                Exception ex2 = TryExecute(() => S2?.Validate(value));

                if (ex1 != null && ex2 != null)
                {
                    throw new ValidationException(string.Format("Validate errors:\n- {0}\n- {1}", ex1.Message, ex2.Message));
                }
            }
            
            private Exception TryExecute (Action func)
            {
                try
                {
                    func();
                    return null;
                }
                catch (ValidationException ex)
                {
                    return ex;
                }
            }
        }

        public class NotSpecification<K> : Specification<K>
        {
            ISpecification<K> S1 = null;

            public NotSpecification(ISpecification<K> spec1)
            {
                S1 = spec1;
            }

            public override void Validate(K value)
            {
                try
                {
                    S1?.Validate(value);
                }
                catch (ValidationException ex)
                {
                    return;
                }
                throw new ValidationException("");
            }
        }
    }
}

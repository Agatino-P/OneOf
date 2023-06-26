using OneOf;
using OneOf.Types;

namespace OneOfSut
{
    public class SuccessOr<T> : OneOfBase<Success, T> where T: class
    {
        public static implicit operator SuccessOr<T>(Success _) => new(_);
        public static implicit operator SuccessOr<T>(T _) => new(_);

        public bool HasErrors(out T tout)
        {
            tout = default!;
            if (TryPickT0(out Success _, out T t))
            {
                return false;
            }

            tout = t; 
            return true;
        }

        protected SuccessOr(OneOf<Success, T> input) : base(input)
        {
        }
    }
}

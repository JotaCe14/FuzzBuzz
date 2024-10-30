namespace FizzBuzz;
public interface IMagicNumberValidator
{
    bool IsMagicNumber(int number);
}

internal sealed class MagicNumberValidator : IMagicNumberValidator
{
    public bool IsMagicNumber(int number)
    {
        throw new NotImplementedException();
    }
}
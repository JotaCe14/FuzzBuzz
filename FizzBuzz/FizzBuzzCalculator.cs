namespace FizzBuzz;
public class FizzBuzzCalculator
{
    private readonly IMagicNumberValidator _magicNumberValidator;

    public FizzBuzzCalculator(IMagicNumberValidator magicNumberValidator)
    {
        _magicNumberValidator = magicNumberValidator;
    }

    public string Calculate(int number)
    {
        if (IsFuzzBuzz(number))
            return "FuzzBuzz";
        if (IsFuzz(number))
            return "Fuzz";
        if (IsBuzz(number))
            return "Buzz";
        return number.ToString();
    }

    private static bool IsBuzz(int number)
    {
        return number % 5 == 0;
    }

    private static bool IsFuzz(int number)
    {
        return number % 3 == 0;
    }

    private static bool IsFuzzBuzz(int number)
    {
        return number % 15 == 0;
    }
}

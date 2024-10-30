using NSubstitute;

namespace FizzBuzz.UnitTests;
public class FizzBuzzCalculatorTests
{
    private readonly IMagicNumberValidator _magicNumberValidator;

    public FizzBuzzCalculatorTests()
    {
        _magicNumberValidator = Substitute.For<IMagicNumberValidator>();
    }

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    public void Calculate_Should_Return_StringRepresentation_When_Number_IsNot_MultipleOf3_Or_Is_MultipleOf5(int number, string expectedOuput)
    {
        //Arrange
        var sut = new FizzBuzzCalculator(_magicNumberValidator);

        //Act
        string otuput = sut.Calculate(number);

        //Assert
        Assert.Equal(expectedOuput, otuput);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void Calculate_Should_Return_Fuzz_When_Number_Is_MultipleOf3_And_IsNot_MultipleOf5(int number)
    {
        //Arrange
        var sut = new FizzBuzzCalculator(_magicNumberValidator);

        //Act
        string otuput = sut.Calculate(number);

        //Assert
        Assert.Equal("Fuzz", otuput);

    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Calculate_Should_Return_Buzz_When_Number_IsNot_MultipleOf3_And_Is_MultipleOf5(int number)
    {
        //Arrange
        var sut = new FizzBuzzCalculator(_magicNumberValidator);

        //Act
        string otuput = sut.Calculate(number);

        //Assert
        Assert.Equal("Buzz", otuput);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void Calculate_Should_Return_FuzzBuzz_When_Number_Is_MultipleOf15(int number)
    {
        //Arrange
        var sut = new FizzBuzzCalculator(_magicNumberValidator);

        //Act
        string otuput = sut.Calculate(number);

        //Assert
        Assert.Equal("FuzzBuzz", otuput);
    }
}

namespace FizzBuzz.UnitTests;
public class FizzBuzzCalculatorTests
{
    [Fact]
    public void Calculate_Should_Return_StringRepresentationOf1_When_Number_Is_1()
    {
        //Arrange
        var sut = new FizzBuzzCalculator();

        //Act
        string otuput = sut.Calculate(1);

        //Assert
        Assert.Equal("1", otuput);
    }

    [Fact]
    public void Calculate_Should_Return_StringRepresentationOf2_When_Number_Is_2()
    {
        //Arrange
        var sut = new FizzBuzzCalculator();

        //Act
        string otuput = sut.Calculate(2);

        //Assert
        Assert.Equal("2", otuput);
    }

    [Fact]
    public void Calculate_Should_Return_StringRepresentationOf4_When_Number_Is_4()
    {
        //Arrange
        var sut = new FizzBuzzCalculator();

        //Act
        string otuput = sut.Calculate(4);

        //Assert
        Assert.Equal("4", otuput);
    }
}

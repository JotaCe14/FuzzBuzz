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
}

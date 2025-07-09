

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("15")]
    [InlineData("2")]
    public void SingleNumberReturnsNumber(string number)
    {
        var calculator = new Calculator();
        var result = calculator.Add(number);

        Assert.Equal(int.Parse(number), result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,3", 5)]
    [InlineData("3,4", 7)]
    public void TwoNumbersReturnsSum(string number,int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(number);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,4", 7)]
    [InlineData("2,3,5", 10)]
    [InlineData("3,4,7", 14)]
    public void AddsAnyLengthReturnsSum(string number, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(number);

        Assert.Equal(expected, result);
    }
}

using Libraries.Abstractions;
using Xunit;

namespace Libraries.UnitTests.CalculatorTests;

public class SumTests
{
    [Fact]
    public void When_Adding_A_Positive_Number_And_Zero_Then_The_Result_Should_Be_The_Positive_Number()
    {
        // Given
        double firstNumber = 8;
        double secondNumber = 0;
        ICalculator sut = new Calculator();

        // When
        double result = sut.Sum(firstNumber, secondNumber);

        // Then
        Assert.Equal(result, firstNumber);
    }
}
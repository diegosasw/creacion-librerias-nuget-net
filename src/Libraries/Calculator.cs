using Libraries.Abstractions;

namespace Libraries;

public class Calculator
    : ICalculator
{
    public double Sum(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
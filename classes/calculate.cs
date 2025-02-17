public class Calculator : Calc
{
    public interface Addition(double a, double b)
    {
        return a + b;
    };

    public interface Subtract(double a, double b)
    {
        return a - b;

    };

    public interface Multiply(double a, double b)
    {
        return a * b;
    };

    public interface Divide(double a, double b)
    {
        return a / b;
    }
};
public class Calculator : Calc
{
    public double Addition(double a, double b)
    {
        return a+b;
    }

    public double Subtract(double a, double b)
    {
        return a-b;
    }

    public double Multiply(double a, double b)
    {
        return a*b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot Divide with zero tihi");
            throw new Exception("Program Terminated :3");
        }
        return a/b;
    }
};
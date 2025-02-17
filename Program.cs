namespace første_oppgave;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insert your first number:");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nInsert your operator: (+, -, *, /)");
        char op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Insert your second number:");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        double result = Sum(firstNum, secondNum, op);
        Console.WriteLine($"\nResult: {result}");
    }

    static double Sum(double firstNum, double secondNum, char op)
    {
        var calculator = new Calculator();
        
        return op switch
        {
            '+' => calculator.Addition(firstNum, secondNum),
            '-' => calculator.Subtract(firstNum, secondNum),
            '*' => calculator.Multiply(firstNum, secondNum),
            '/' => calculator.Divide(firstNum, secondNum),
            _ => throw new ArgumentException("Invalid operator")
        };
    }
}

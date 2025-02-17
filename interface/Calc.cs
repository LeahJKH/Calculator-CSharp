public interface Calc
{
 /// <summary>
 /// Adds two numbers togheter
 /// </summary>
 /// <param name="a">The value of "a"</param>
 /// <param name="b">The value of "b" </param>
 /// <returns>a + b</returns>
 double Addition(double a,double b);

/// <summary>
/// Subtracts two numbers togheter
/// </summary>
/// <param name="a">The value of "a"</param>
/// <param name="b">The value of "b"</param>
/// <returns>a - b</returns>
 double Subtract(double a,double b);

/// <summary>
/// Multiplies two numbers togheter
/// </summary>
 /// <param name="a">The value of "a"</param>
 /// <param name="b">The value of "b" </param>
/// <returns></returns>
 double Multiply(double a,double b);

/// <summary>
/// Divides two numbers togheter
/// </summary>
 /// <param name="a">The value of "a"</param>
 /// <param name="b">The value of "b" </param>
/// <returns></returns>
 double Divide(double a,double b);
};
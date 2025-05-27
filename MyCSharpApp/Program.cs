namespace MyCSharpApp;
public class Calculator
{
    public static int Add(int a, int b) => a + b;
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Результат: {Calculator.Add(3, 5)}");
    }
}
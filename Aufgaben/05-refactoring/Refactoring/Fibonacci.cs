namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n)
    {
        int previous = 0;
        int current = 1;
        int result = 0;

        if (n < 0)
        {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        }
        if (n == 0 || n == 1)
        {
            return n;
        }
        for (int i = 1; i < n; i++)
        {
            result = previous + current;
            previous = current;
            current = result;
        }
        return result;
    }
}
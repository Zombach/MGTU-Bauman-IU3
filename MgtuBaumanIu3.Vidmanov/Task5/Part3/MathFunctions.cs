namespace MgtuBaumanIu3.Vidmanov.Task5.Part3;

public static class MathFunctions
{
    public static long Fact(int n)
    {
        if (n < 0) { throw new ArgumentException("Аргумент не может быть отрицательным.", nameof(n)); }
        if (n is 0 or 1) { return 1; }
        long result = 1;
        for (int i = 2; i <= n; i++) { result *= i; }
        return result;
    }

    public static double Reciprocal(double x) => x is 0
    ? throw new DivideByZeroException("Деление на ноль невозможно.")
    : 1.0 / x;

    public static double FracPart(double x) => x - Math.Floor(x);

    public static bool IsEven(int n) => n % 2 is 0;

    public static bool IsOdd(int n) => !IsEven(n);

    public static double Crt(double x) => x < 0
    ? throw new ArgumentException("Аргумент не может быть отрицательным.", nameof(x))
    : Math.Pow(x, 1.0 / 3.0);
    

    public static double DegToRad(double degrees) => degrees * Math.PI / 180.0;

    public static double RadToDeg(double radians) => radians * 180.0 / Math.PI;

    public static bool BinaryDigit(int n) => (n > 0) && ((n & (n - 1)) is 0);
}
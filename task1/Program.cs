// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int EvenCount(int n, int b = 0)
{
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 != 0)
            if ((i % 10) % 2 == 0)
                b++;

    }
    return b;
}
int OddCount(int n, int b = 0)
{
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 != 0)
            if ((i % 10) % 2 != 0)
                b++;

    }
    return b;
}
int DigitCount(int n)
{
    {
        if (n == 0)
            return 0;
        return 1 + DigitCount(n / 10);
    }
}
int ZeroCount(int n, int b = 0)
{
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 == 0)
            b++;
    }
    return b;
}
int MinDigit(int n)
{
    int mn = 9;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 < mn) mn = i % 10;
    }
    return mn;
}
int MaxDigit(int n)
{
    int mx = 0;
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 10 > mx) mx = i % 10;
    }
    return mx;
}
int SumDigit(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return (n % 10 + SumDigit(n / 10));
}

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Even : " + EvenCount(a));
Console.WriteLine("Odd : " + OddCount(a));
Console.WriteLine("Zeros : " + ZeroCount(a));
Console.WriteLine("Digits : " + DigitCount(a));
Console.WriteLine("Min : " + MinDigit(a));
Console.WriteLine("Max : " + MaxDigit(a));
Console.WriteLine("Sum of Digits: " + SumDigit(a));
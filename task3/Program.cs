// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());
int[] s = new int[n];
for (int i = 0; i < n; i++)
{
    s[i] = Convert.ToInt32(Console.ReadLine());
}
int neg, pos, zero, even, odd, mx, mn, sum;
neg = pos = zero = even = odd = sum = 0;
mn = mx = s[0];
for (int i = 0; i < n; i++)
{
    if (s[i] < 0) neg++;
    if (s[i] > 0) pos++;
    if (s[i] == 0) zero++;
    if (i % 10 != 0)
        if ((i % 10) % 2 == 0)
            even++;
    if (i % 10 != 0)
        if ((i % 10) % 2 != 0)
            odd++;
    if (s[i] < mn) mn = s[i];
    if (s[i] > mx) mx = s[i];
    sum += s[i];
}
Console.WriteLine(@$"Negative = {neg}
Positive = {pos}
Zeros = {zero}
Even = {even}
Odd = {odd}
Max = {mx}
Min = {mn}
Sum of Digits = {sum} ");
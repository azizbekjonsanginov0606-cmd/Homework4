// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());

int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] =Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 1; i < n; i++)
{
    if (a[i] > a[i - 1])
    {
        cnt++;
    }
}
Console.WriteLine(cnt+"-to");
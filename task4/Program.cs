// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());
int[] s= new int[n];
for (int i = 0; i < n; i++)
{
    s[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (i%2==0)
    {
        Console.Write(s[i]+" ");
    }
}
Console.WriteLine();
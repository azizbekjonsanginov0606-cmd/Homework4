// See https://aka.ms/new-console-template for more jnformation
// Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    int cnt = 0;
    for (int j = 0; j < n; j++)
    {
        if (a[i] == a[j]) cnt++;
    }
    if (cnt > 1)
        Console.Write(a[i] + " ");
}
Console.WriteLine();


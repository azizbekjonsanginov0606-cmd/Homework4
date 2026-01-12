// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("From = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("To = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------");
if (a < b)
{
    for (int i = a; i <= b; i++)
    {
        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine($"{i} * {x} = {i * x}");
        }
        Console.WriteLine("-------------------------------");
    }
}
if (a > b)
{
    for (int i = a; i >= b; i--)
    {
        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine($"{i} * {x} = {i * x}");
        }
        Console.WriteLine("-------------------------------");
    }
}
// tarzi 2 bo funksiya
//        void karatz(int x){
//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"{x} * {i} = {i * x}");
//         }
//         Console.WriteLine("-------------------------------");
//        }
// Console.WriteLine("From = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("To = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("-------------------------------");
// if (a < b)
//     for (int i = a; i <= b; i++)
//     {
//         karatz(i);
//     }
// if (a > b)
// {
//     for (int i = a; i >= b; i--)
//     {
//         karatz(i);
//     }
// }
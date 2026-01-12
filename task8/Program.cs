// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int Sum(int x,int y)
{
    return x+y;
}
int  Subtract(int x,int y)
{
    return x-y;
}
int Multiplication(int x,int y)
{
    return x*y;
}
int Division(int x,int y)
{
    return x/y;
}
Console.WriteLine("The first number is: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The operation is: ");
char b = Convert.ToChar(Console.ReadLine());
Console.WriteLine("The first number is: ");
int c = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case '+':Console.WriteLine($"{a} + {c} = {Sum(a,c)}");break;
    case '-':Console.WriteLine($"{a} - {c} = {Subtract(a,c)}");break;
    case '*':Console.WriteLine($"{a} * {c} = {Multiplication(a,c) }");break;
    case '/':Console.WriteLine($"{a} / {c} = {Division(a,c)}");break;
    default:Console.WriteLine("error");break;
}

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
    int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    void PrintFibonacci(int current, int max)
    {
        if (current == max)
            return;

        Console.Write(Fibonacci(current) + " ");
        PrintFibonacci(current + 1, max);
    }
    Console.Write("Input number of terms for the Fibonacci series : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The Fibonacci series of {a} terms is : ");
    PrintFibonacci(0,a);
    Console.WriteLine();
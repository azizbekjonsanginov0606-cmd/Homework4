// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
    double Power(double a, int b)
    {
        if (b == 0)
            return 1;
            else return a*Power(a,b-1);
    }
        double a = Convert.ToDouble(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Натиҷа: {Power(a, b)}");
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
        Console.WriteLine($"The value of {a} to the power of {b} is : {Power(a, b)}");
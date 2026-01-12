// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
char CheckGrade(int grade)
{
    if(grade>=90 && grade<=100) return 'A';
    if(grade>=80 && grade<=89) return 'B';
    if(grade>=70 && grade<=79) return 'C';
    if(grade>=60 && grade<=69) return 'D';
    if(grade>=0 && grade<=59) return 'F';
    return ' ';
}
int a = Convert.ToInt32(Console.ReadLine());
if (a>=0 && a<=100)
Console.WriteLine(CheckGrade(a));
else Console.WriteLine("The score must be between 0 and 100. You entered an invalid number. Please try again.");
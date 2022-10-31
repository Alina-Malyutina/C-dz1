Console.WriteLine("This program defines max and min of two numbers.");
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
int min = num1;

if(num2 > max)
{
    max = num2;
}
else
{
    min = num2;
}
Console.WriteLine($"Max number is {max}, min is {min}.");

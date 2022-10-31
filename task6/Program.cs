Console.WriteLine("This program defines is your number even or not.");
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($"Number {number} is even");

if (number % 2 == 1) Console.WriteLine($"Number {number} is odd");

if (number % 2 == -1) Console.WriteLine($"Number {number} is odd");
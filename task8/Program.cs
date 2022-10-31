Console.WriteLine("This program show all even numbers between 1 and your number."); 
Console.WriteLine("ATTENTION: you number must be greater than 1!");
Console.WriteLine("Enter your number: ");
int endnum = Convert.ToInt32(Console.ReadLine());
int printednum = 2;
if (endnum > 1)
{
    while (printednum < endnum && printednum % 2 == 0)
    {
        Console.Write($"{printednum}, ");
        printednum += 2;
    }
}

if (endnum > 1 && endnum % 2 == 0)
{
    Console.Write(endnum);
}

if (endnum < 1)
{
    Console.WriteLine("Please, enter number, greater than 1!");
}
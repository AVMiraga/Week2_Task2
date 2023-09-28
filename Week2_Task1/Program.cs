using System;

//Task 1

int number = int.Parse(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Please enter a positive number");
    return; //To exit from the program
}

int product = 1;
while (product < number)
{
    product *= 2;
}
Console.WriteLine($"Is {number} power of 2?\n" + (number == product));

//Task 2
Console.WriteLine();
if (number <= 1)
{
    Console.WriteLine("Please enter a number greater than 1");
    return;
}
for (int i = 2; i * i <= number; i++) //i * i <= number is the same as i <= Math.Sqrt(number)
{
    if (number % i == 0)
    {
        Console.WriteLine($"Is {number} prime?\nFalse");
        return;
    }
}
Console.WriteLine($"Is {number} prime?\nTrue");
using System;

//Task 1

int number = int.Parse(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Please enter a positive number");
}
else
{
    int product = 1;
    while (product < number)
    {
        product *= 2;
    }
    Console.WriteLine($"Is {number} power of 2?\n" + (number == product));
}

Console.WriteLine();
//Task 2

number = int.Parse(Console.ReadLine()); //Reusing the same variable

if (number <= 1)
{
    Console.WriteLine("Please enter a number greater than 1");
}
else
{
    for (int i = 2; i * i <= number; i++) //i * i <= number is the same as i <= Math.Sqrt(number)
    {
        if (number % i == 0)
        {
            Console.WriteLine($"Is {number} prime?\nFalse");
            return; //Exit the program
        }
    }
    Console.WriteLine($"Is {number} prime?\nTrue");
}


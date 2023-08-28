// See https://aka.ms/new-console-template for more information
using System.Runtime.ExceptionServices;

Console.WriteLine("Hello, World!");

for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

Random rand = new Random();
for(int i = 1; i <= 5; i++)
{
    
    Console.WriteLine(rand.Next(10,20));
}

Random rand = new Random();
int sum = 0;
for(int i = 1; i <= 5; i++)
{
    int rando = rand.Next(10,20);
    sum += rando;
}
    Console.WriteLine(sum);

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}

for (int i = 1; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0 )
    {
        Console.WriteLine(i);
    }
}

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    if(i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    if(i % 3 == 0 && i % 5 == 0 )
    {
        Console.WriteLine("FizzBuzz");
    }
}




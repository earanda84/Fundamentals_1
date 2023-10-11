
for (int i = 1; i <= 255; i++)
{
    Console.WriteLine($"Num: {i} ==> With for loop");
}

Console.WriteLine("***********************");

int value1 = 1;

while (value1 <= 255)
{
    Console.WriteLine($"Num: {value1} => With While");
    value1++;
}

Console.WriteLine("***********************");
int value2 = 1;

while (value2 < 100)
{
    if ((value2 % 3 == 0 || value2 % 5 == 0) && !(value2 % 3 == 0 && value2 % 5 == 0))
    {
        Console.WriteLine($"Divisible por 3 o 5: {value2} ==> While loop");
    }
    value2++;
}

Console.WriteLine("***********************");

for (int i = 1; i < 100; i++)
{
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine($"Divisible por 3 o 5: {i} ==> for loop");
    }
}

Console.WriteLine("***********************");

for (int i = 1; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"Para el número {i}: FizzBuzz ==> for loop");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"Para el número {i}: Fizz ==> for loop");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"Para el número {i}: Buzz for loop");
    }
}

Console.WriteLine("***********************");

int value3 = 1;

while (value3 < 100) { 
    if (value3 % 3 == 0 && value3 % 5 == 0)
    {
        Console.WriteLine($"Para el número {value3}: FizzBuzz ==> While loop");
    }
    else if (value3 % 3 == 0)
    {
        Console.WriteLine($"Para el número {value3}: Fizz ==> While loop");
    }
    else if (value3 % 5 == 0)
    {
        Console.WriteLine($"Para el número {value3}: Buzz ==> While loop");
    }
    value3++;
}

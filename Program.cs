int a, b, c;
a = int.Parse(Console.ReadLine()!);
b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Максимальное число:" + a);
}
else
{
    Console.WriteLine("Максимальное число:" + b);
}

a = int.Parse(Console.ReadLine()!);
b = int.Parse(Console.ReadLine()!);
c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число:" + a);
    }
    else
    {
        Console.WriteLine("Максимальное число:" + c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("Максимальное число:" + b);
    }
    else
    {
        Console.WriteLine("Максимальное число:" + c);
    }
    
}


a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

a = int.Parse(Console.ReadLine()!);
for (int i = 1; i < (a + 1); i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
}

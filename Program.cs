// задача_2


int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) 
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);


// задача_4

int max = 0;

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > max)
{
    max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);

// задача 6

Console.Write("Введите загаданное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remains = number % 2;

if(remains == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}

//задача 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;

if(number > 1)
{
    while(even <= number)
    {
        Console.Write(even + " ");
        even = even + 2;
    }
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a>0)
    {
        if ((a % 2)==0)
    {
        Console.WriteLine($"{a} - четное число");
    }
        else
    {
        Console.WriteLine($"{a} - нечетное число");
    }   
    }
else
    {
        Console.WriteLine($"{a} - вы ввели отрицательно число");
    }
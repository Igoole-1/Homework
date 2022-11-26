// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("  ");
for (int i = 1; i <= n; i++) // находим все числа до N
{
    if ((i % 2)==0) // Находим все четные
    {  
    Console.WriteLine(i);
    }
}

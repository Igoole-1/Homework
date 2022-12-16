// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());;
int sum = 0;
for (int i=0; i<M; i++)
{
    Console.WriteLine("Введите число ");
    double value = Convert.ToInt32(Console.ReadLine());
        if (value>0)
        { 
        sum = sum+1;
        }
}
Console.WriteLine (sum);
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine ("Введите число от 100 до 1000");
int a = Convert.ToInt32(Console.ReadLine());

int a1 = a / 10;
//Console.WriteLine(a1);

int a3 = a1 % 10;
//Console.WriteLine(a3);

int b = a1*10 + a3;
//Console.WriteLine(b);

int a2 = b % 10;
Console.WriteLine(a2);

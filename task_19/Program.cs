// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [5];
int i=0;
for (i=0; i<5; i=i+1)
{
   numbers [i] = a%10;
   a = a/10;
   //Console.WriteLine (numbers [i]);
   //Console.WriteLine (i);
   //Console.WriteLine (a);
}
if (numbers [0]*10 + numbers [1] == numbers [4]*10 + numbers [3])
   {
      Console.WriteLine ("Yes, this is палиндром");
   }
else
{
   Console.WriteLine ("No, this is not палиндром");
}

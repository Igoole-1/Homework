//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine ("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int l=0;
if (a>99)
{
for (l=0; b>0; l++)
{
   b = (b / 10); 
}
//Console.WriteLine(l);
//Console.WriteLine(b);
//Console.WriteLine(a);

while (l>3)
{
  l = (l-1);
  a = (a/10);
  //Console.WriteLine(l);
  //Console.WriteLine(a);
}
Console.WriteLine(a%10);
}
else 
{
    Console.WriteLine("третьей цифры нет");
}

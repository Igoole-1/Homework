// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int row = 3;
int col = 4;
int [,] arr = new int [row,col];

arr = Nums(arr);
PrintNums (arr);

int [,] Nums(int[,]arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
        arr [i,j] = new Random ().Next(0,11); 
        }
    }    
return arr;    
}
void PrintNums (int [,]arr)
{
Console.WriteLine ();
for (int i=0; i<arr.GetLength(0); i++)
{
    for (int j=0; j<arr.GetLength(1); j++)
    {
    Console.Write ($"{arr[i,j]} ");
    }
    Console.WriteLine ();
}
}
Console.WriteLine("Введите строку ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int b = Convert.ToInt32(Console.ReadLine());
//Console.Write ($"{arr[a-1,b-1]} ");
if (((a-1)>=row) || ((b-1)>=col))
{
    Console.WriteLine ("Элемента с такой позицией нет в массиве");
}
else
{
    Console.Write ($"{arr[a-1,b-1]} ");
}

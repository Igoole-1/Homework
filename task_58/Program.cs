//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Задайте размер матриц :");
Console.WriteLine("Введите число строк первой матрицы ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов первой матрицы");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число строк второй матрицы");
int C = B;

Console.WriteLine("и число столбцов второй матрицы");
int D = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[A, B];
int[,] SecondMatrix = new int[C, D];
int[,] ResultMatrix = new int[A, D];
FirstMatrix = CreateArray (FirstMatrix);
PrintNums(FirstMatrix);
//Console.Write(" | ");
SecondMatrix = CreateArray (SecondMatrix);
PrintNums(SecondMatrix);


for (int i = 0; i < ResultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < C;k++)
        {
            sum = sum + (FirstMatrix [i,k] * SecondMatrix [k,j]);
        }
        ResultMatrix [i,j]=sum;
    }
}
PrintNums(ResultMatrix);

int[,] CreateArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintNums(int[,] arr)
{
    Console.WriteLine ();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
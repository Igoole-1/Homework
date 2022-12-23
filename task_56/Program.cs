// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] arr = new int[4, 4];
arr = Nums(arr);
PrintNums(arr);
RowMin(arr);

int[,] Nums(int[,] arr)
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
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RowMin(int[,] arr)
{
    int min = 0;
    int line = 0;

    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        //line = i;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
            //Console.WriteLine($"{sum} ");
        }
        //Console.Write($"{sum}; ");
        if (min == 0)
        {
            min = sum;
            //line = i;
        }
        if (sum < min)
        {
            min = sum;
            line = i;
        }
        //Console.WriteLine($"{min}");
    }
    Console.Write($"{line+1} строка");
}

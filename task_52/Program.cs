// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int [,] arr = new int [3,4];

arr = Nums (arr);
PrintNums (arr);
int [,] Nums (int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
        {
        for (int j=0; j<arr.GetLength(1); j++)
            {
            arr [i,j] = new Random ().Next (0,11);
            }
        }    
    return arr;
}

void PrintNums (int [,] arr)
{
    Console.WriteLine();
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
        Console.Write ($"{arr[i,j]} ");
        }
    Console.WriteLine();
    }
}
int i =0;
int j =0;
double sum = 0;
double avr = 0;

for (j=0; j<arr.GetLength(1); j++)
        {
        sum=0;
            for (i=0; i<arr.GetLength(0); i++)
                {
                   sum=sum+arr[i,j]; 
                }
        avr=sum/(i);
        Console.Write ("{0:0.#}; ", avr);
        //Console.Write ($"{avr}; ");
        //Console.WriteLine (sum);
        }

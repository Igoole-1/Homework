// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] arrRand(int len) // заполняю массив случайными числами
{
    int[] a = new int[len];
    for (int i = 0; i<a.Length; i++)
    {
        a[i] = new Random().Next(100,1000);
    }    
    return a;
}

void arrPrint(int[] a) // вывожу массив
{
    for (int i = 0; i<a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();    
}
int[] arr = arrRand(5);
arrPrint(arr);

int count = 0;
for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            count = count + 1;
        }
    } 
Console.WriteLine(count);

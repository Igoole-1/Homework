// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] arrRand(int len) // заполняю массив случайными числами
{
    int[] a = new int[len];
    for (int i = 0; i<a.Length; i++)
    {
        a[i] = new Random().Next(-10,10);
    }    
    return a;
}

void arrPrint(int[] a) // вывожу массив
{
    for (int i = 0; i<a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();    
}
int[] arr = arrRand(6);
arrPrint(arr);

int sum = 0;
for (int i = 0; i<arr.Length; i++)
    {
        if (i%2!=0)
        {
            sum = arr[i] + sum;
        }
    } 
Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] arrRand(int len) // заполняю массив случайными числами
{
    double[] a = new double [len];
    for (int i = 0; i<a.Length; i++)
    {
        a[i] = new Random().Next(1,100);
    }    
    return a;
}

void arrPrint(double[] a) // вывожу массив
{
    for (int i = 0; i<a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();    
}
double[] arr = arrRand(6);
arrPrint(arr);

double min = arr[0];
double max = arr[0];
for (int i = 0; i<arr.Length; i++)
    {
        if (min>arr[i])
        {
            min = arr[i];
        }
        if (max<arr[i])
        {
            max = arr[i];
        }
    } 
Console.WriteLine(max-min);

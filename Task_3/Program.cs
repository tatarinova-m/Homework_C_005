// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

float[] arr = new float[5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write($" {arr[i]}");
}


float max = arr[0];
float min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}
float result = max - min;
Console.WriteLine();
Console.WriteLine(result);

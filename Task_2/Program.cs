// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[4];
Console.WriteLine(string.Join(" ", arr));

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100, 100);
    Console.Write($" {arr[i]} ");
}
Console.WriteLine();
int sum = 0;
sum = arr[0] + arr[2];
Console.WriteLine(sum);
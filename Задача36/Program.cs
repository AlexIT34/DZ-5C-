// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[8];
Random rand = new Random();
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
for (int i = 1; i < array.Length; i += 2)
{
    n = array[i] + n;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов array[1], [3], [5], [7] = {n}");

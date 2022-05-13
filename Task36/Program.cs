// Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
void FillArray(int[]array, int A, int B)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}
void PrintArray(int[] array)
{
    for(int i=0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int[]array = new int[6];
FillArray(array, -100, 100);
PrintArray(array);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array.Length; i+=2)
{
    sum = sum + array[i];
}
Console.Write(sum);

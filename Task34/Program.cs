// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
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
int[]array = new int[5];
FillArray(array, 100, 199);
PrintArray(array);
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);
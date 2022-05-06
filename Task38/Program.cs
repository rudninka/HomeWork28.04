// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
void FillArray(double[]array, int A, int B)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(A, B)+ new Random().NextDouble(); 
    }
}
void PrintArray(double[] array)
{
    for(int i=0; i< array.Length; i++)
    {
        Console.Write(Math.Round(array[i],2) + " ");
    }
}
double[]array = new double[5];
FillArray(array, 0, 10);
PrintArray(array);
Console.WriteLine();
double min = array[0];
double max = array[array.Length - 1];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}
Console.Write($"Максимальный элемент массива {max}, а минимальный {min}");
Console.Write($"Разница между наибольшим и наименьшим элементами {max - min}");

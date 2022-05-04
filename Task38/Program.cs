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
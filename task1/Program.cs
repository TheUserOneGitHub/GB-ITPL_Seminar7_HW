// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next();
        }
    }
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine($"");
    }  
}



Console.WriteLine("Enter rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns number");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

FillAray(array);
PrintArray(array);
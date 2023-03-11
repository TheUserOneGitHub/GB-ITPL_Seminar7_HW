// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillAray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-5,6);
        }
    }
}

void PrintArray(int[,] array)
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

void SumByColumns(int[,] array, int m)
{
    int count = -1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        count++;
        double arithMean = sum / m;
        Console.WriteLine($"The arithmetic mean of column {count} is {arithMean}");
    }
}


Console.WriteLine("Enter rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns number");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FillAray(array);
PrintArray(array);
SumByColumns(array, m);
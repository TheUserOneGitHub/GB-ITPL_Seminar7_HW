// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

void FillAray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 6);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t");
        }
        Console.WriteLine($"");
    }
}

void FindNumber(double[,] array, double number)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                Console.WriteLine($"The number position is row {i}, column {j}");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"The array does not contain number {number}");
    }
}



Console.WriteLine("Enter number you want to find in the array");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter rows number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter columns number");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];



FillAray(array);
PrintArray(array);
FindNumber(array, number);
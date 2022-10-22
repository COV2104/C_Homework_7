// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] Fill2DArray()
{
    int[,] array = new int[rows, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void AveregeColumnArray(int [,] array)
{
    int[] sum = new int[column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i,j];
        }
    }

    foreach (double item in sum)
    {
        Console.Write($"{Math.Round((item / rows),1)}\t");
    }
    Console.WriteLine();
}


int[,] massiv = Fill2DArray();
Print2DArray(massiv);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");;
AveregeColumnArray(massiv);
Console.WriteLine();
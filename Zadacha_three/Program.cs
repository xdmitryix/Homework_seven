// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void ArithmeticMean(double[,] array)
{
    double sum = 0;
    double result = 0;
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            count++;
        }
        result = sum / count;
        Console.Write("{0:0.0}", result);
        Console.Write("; ");
        result = 0;
        sum = 0;
        count = 0;
    }
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}


int rows = 3;
int columns = 4;
double[,] matrix = CreateRandomArray(rows, columns, 1, 100);
ShowArray(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца:");
ArithmeticMean(matrix);
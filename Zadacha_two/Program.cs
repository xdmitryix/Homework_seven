// Внимание !!! Условие задачи было скорректировано преподавателем на лекции.

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает номер позиции элемента в двумерном массиве, или отвечает, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



void PositionNumber(int[,] array, int number)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"строка: {i + 1} столбец: {j + 1}");
                result++;
            }
        }
    }
    if (result == 0) Console.WriteLine("такого элемента нет");
}

void ShowArray(int[,] array)
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

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int rows = 3;
int columns = 4;
int[,] matrix = CreateRandomArray(rows, columns, 1, 100);
ShowArray(matrix);
Console.WriteLine();
int number = DataEntry("Введи число: ");
PositionNumber(matrix, number);









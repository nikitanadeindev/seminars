﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
//  с наименьшей суммой элементов: 1 строка



int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[] CountValueOfRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] arr = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for(int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

int MinValue(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i])
            index = i;
    }
    return index + 1;
}

Console.Write("Введите количество строк в двумерном массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matr = CreateMatrix(row, column, 1, 9);
int[] array = CountValueOfRows(matr);
int minValue = MinValue(array);
PrintMatrix(matr);
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minValue}");
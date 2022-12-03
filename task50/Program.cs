// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int[] UserSearch()
{   
    int[] arr = new int[2];
    Console.Write("Введите индекс строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    arr[0] = row;
    arr[1] = column;

    return arr;
}

int ReturnValueByIndex(int[,] matrix, int[] search)
{
    int value = 0;
    if(search[0] < matrix.GetLength(0) && search[1] < matrix.GetLength(1))
        return value = matrix[search[0], search[1]];
    else
        return value;
}

int[] userSearch = UserSearch();
int[,] array2D = CreateMatrix(3, 4, -50, 50);
int result = ReturnValueByIndex(array2D, userSearch);
Console.Write(userSearch[0] + "," + userSearch[1]);
Console.WriteLine(result == 0 ? " -> такого элемента в массиве нет" 
                              : " -> " + result);
PrintMatrix(array2D);
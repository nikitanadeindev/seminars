// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

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

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[] MatrixToSortedArray(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int z = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[z] = matrix[i, j];
            z++;
        }
    }
    Array.Sort(arr);
    return arr;
}

void FrequencyDictionary(int[] arr)
{
    int counter = 1;
    int number = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] == number)
            counter++;
        else
        {
            PrintMessage(number, counter);
            counter = 1;
            number = arr[i];
        }
    }

    PrintMessage(number, counter);
}

void PrintMessage(int num, int count)
{
    if(count % 10 == 2 || count % 10 == 3 || count % 10 == 4 )
        Console.WriteLine($"Число {num} встречается {count} раза");
    else
        Console.WriteLine($"Число {num} встречается {count} раз");
}

int[,] matr = CreateMatrix(4, 4, 1, 9);
int[] array = MatrixToSortedArray(matr);
FrequencyDictionary(array);
Console.WriteLine("\nИсходный массив");
PrintArray(array);
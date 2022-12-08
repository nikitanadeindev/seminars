// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива

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

int[] SmallestValue(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] array = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

int[,] RemoveRowAndColumn(int[,] matrix, int[] min)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] newMatrix = new int[rows - 1, columns - 1];
    int k = 0;

    for (int i = 0; i < rows - 1; i++)
    {
        int l = 0;
        if (k == min[0]) k++;
        for (int j = 0; j < columns - 1; j++)
        {
            if (l == min[1]) l++;
            newMatrix[i, j] = matrix[k, l];
            l++;
        }
        k++;
    }
    return newMatrix;
}

int[,] matr = CreateMatrix(4, 4, 1, 9);
int[] minimum = SmallestValue(matr);
int[,] newMatr = RemoveRowAndColumn(matr, minimum);
PrintMatrix(matr);
Console.WriteLine(minimum[0]);
Console.WriteLine(minimum[1]);
PrintMatrix(newMatr);
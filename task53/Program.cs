
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}, ");
            else Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

void SwapRows(int[,] matr)
{
    for(int i = 0; i <= matr.GetLength(0); i++)
    {   // Записываем в переменную значение элемента i последней строки
        int lastRowValue = matr[matr.GetLength(0) - 1, i];
        // В элемент i последней строки записываем значение элемента i первой строки
        matr[matr.GetLength(0) - 1, i] = matr[0, i];
        // В элемент i первой строки записываем значение элемента i последней строки
        matr[0, i] = lastRowValue;
    }
}

int[,] matrix = CreateMatrix(3, 4, 1, 9);
Console.WriteLine("Изначальная матрица");
PrintMatrix(matrix);
Console.WriteLine("Измененная матрица");
SwapRows(matrix);
PrintMatrix(matrix);
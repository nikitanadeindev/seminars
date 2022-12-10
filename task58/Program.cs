// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplier(int[,] matrA, int[,] matrB)
{
    if (matrA.GetLength(1) != matrB.GetLength(0))
        throw new Exception("Матрицы нельзя перемножить");
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }

    return matrC;
}


Console.Write("Введите количество строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = CreateMatrix(rowsA, columnsA, 1, 9);
int[,] matrixB = CreateMatrix(rowsB, columnsB, 1, 9);
int[,] resultMatrix = MatrixMultiplier(matrixA, matrixB);

Console.WriteLine("Матрица A");
PrintMatrix(matrixA);
Console.WriteLine("\nМатрица B");
PrintMatrix(matrixB);
Console.WriteLine("\nРезультатирующая матрица");
PrintMatrix(resultMatrix);
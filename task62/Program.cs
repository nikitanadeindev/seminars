// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiralMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    //С помощью переменной number задаются числа внутри массива начиная с 1.
    int number = 1;

    //Заполняем периметр массива по часовой стрелке.
    for (int y = 0; y < rows; y++)
    {
        array[0, y] = number;
        number++;
    }
    for (int x = 1; x < columns; x++)
    {
        array[x, rows - 1] = number;
        number++;
    }
    for (int y = rows - 2; y >= 0; y--)
    {
        array[columns - 1, y] = number;
        number++;
    }
    for (int x = columns - 2; x > 0; x--)
    {
        array[x, 0] = number;
        number++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int c = 1;
    int d = 1;

    while (number < columns * rows)
    {

        //Движемся вправо.
        while (array[c, d + 1] == 0)
        {
            array[c, d] = number;
            number++;
            d++;
        }

        //Движемся вниз.
        while (array[c + 1, d] == 0)
        {
            array[c, d] = number;
            number++;
            c++;
        }

        //Движемся влево.
        while (array[c, d - 1] == 0)
        {
            array[c, d] = number;
            number++;
            d--;
        }

        //Движемся вверх.
        while (array[c - 1, d] == 0)
        {
            array[c, d] = number;
            number++;
            c--;
        }
    }

    //При данном решении в центре всегда остаётся незаполненная ячейка.
    //Убираем её при помощи следующего цикла.
    for (int x = 0; x < columns; x++)
    {
        for (int y = 0; y < rows; y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = number;
            }
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}, ");
        }
        Console.WriteLine("|");
    }
}

int[,] spiralArray = FillSpiralMatrix(4,4);
PrintMatrix(spiralArray);
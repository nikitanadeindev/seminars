// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateArray3D(int rows, int columns, int depth)
{
    int[] temp = new int[rows * columns * depth];
    int[,,] array = new int[rows, columns, depth];
    NonRepeatingRandom(temp);

    int counter = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[counter];
                counter++;
            }
        }
    }
    return array;
}

void NonRepeatingRandom(int[] temp)
{
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
                number = temp[i];
            }
            number = temp[i];
        }
    }
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3}({i}, {j}, {k}), ");
            }
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = CreateArray3D(2, 2, 2);
PrintArray3D(array3D);

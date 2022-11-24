// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void CreateArray()
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100);
}

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

CreateArray();
PrintArray();
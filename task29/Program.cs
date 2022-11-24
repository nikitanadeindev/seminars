// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void CreateArray(int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(100);
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");
}

CreateArray(array);
PrintArray(array);
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

int[] RandomArray(int[] array)
{
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);

    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

RandomArray(array);
PrintArray(array);
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);

    return arr;
}

int[] ArrayCopy(int[] arr)
{
    int[] newArray = new int[arr.Length];

    for(int i = 0; i < arr.Length; i++)
        newArray[i] = arr[i];
    
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + " ");
        else
            Console.Write(arr[i]);
    }
}

int[] array = CreateArray(6, 1, 9);
int[] someArray = ArrayCopy(array);

PrintArray(array);
Console.WriteLine();
PrintArray(someArray);
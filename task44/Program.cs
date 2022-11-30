int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;

    for(int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonacci(number);
PrintArray(array);
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + "");
        else
            Console.Write(arr[i]);
    }
}

int DigitsCount(int num) // Counting the size of the array
{
    int digits = 0;
    while (num > 0)
    {
        num /= 2;
        digits++;
    }

    return digits;
}

int[] DecimalToBinary(int num, int size)
{
    int[] bin = new int[size];

    for (int i = 0; i < bin.Length; i++)
    {
        bin[i] = num % 2;
        num /= 2;
    }
    Array.Reverse(bin);
    return bin;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int arraySize = DigitsCount(number);
int[] binaryArray = DecimalToBinary(number, arraySize);
PrintArray(binaryArray);
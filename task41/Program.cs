// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] UserArray()
{
    Console.Write("Сколько вы хотите ввести чисел?: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.Write(arr[i]);
    }
}

int NaturalNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }

    return count;
}

int[] array = UserArray();
PrintArray(array);
int result = NaturalNumbers(array);
Console.Write(" -> " + result);
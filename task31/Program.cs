// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(min, max + 1);

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) 
            Console.Write(arr[i] + ", ");
        else 
            Console.Write(arr[i]);
    }
    Console.Write("]");
}

int GetSumNegativeElem(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}

int GetSumPositiveElem(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(arraySize, min, max);
int negativeSum = GetSumNegativeElem(array);
int positiveSum = GetSumPositiveElem(array);
Console.WriteLine($"Сумма отрицательных чисел = {negativeSum}\nСумма положительных чисел = {positiveSum}");
PrintArray(array);
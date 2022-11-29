// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size, int rndRange)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < arr.Length; i++) 
        arr[i] = Math.Round(rnd.NextDouble() * rndRange, 1);

    return arr;
}

void PrintArray(double[] arr)
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

double SubNumbers (double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    // Finding the maximum number
    for(int i = 1; i < arr.Length; i++)
    {
        if(max <= arr[i])
            max = arr[i];
    }

    // Finding the minimum number
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] <= min)
            min = arr[i];
    }

    return max - min;
}

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон чисел : ");
int range = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(arraySize, range);
PrintArray(array);
double result = SubNumbers(array);
Console.Write(" -> " + result);
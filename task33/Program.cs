// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool IsThereNumber(int number, int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == number)
            return true;
    }

    return false;
}

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Какое число проверяется на наличие?: ");
int search = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(arraySize, min, max);
bool isThereNumber = IsThereNumber(search, array);
string result = (isThereNumber == true) ? "да" : "нет";

Console.Write($"{search}; массив ");
PrintArray(array);
Console.Write(" " + result);
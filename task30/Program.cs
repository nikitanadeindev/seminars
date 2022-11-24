Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);

    return array;
}

int[] randomArray = RandomArray(arraySize);

for(int i = 0; i < randomArray.Length; i++)
{
    Console.Write(randomArray[i] + " ");
}
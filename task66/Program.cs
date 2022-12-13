// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
    Console.WriteLine(ElementsSum(secondNum, firstNum));
if(firstNum < secondNum)
    Console.WriteLine(ElementsSum(firstNum, secondNum));

// Не стал писать условие firstNum == secondNum потому что в таком случае
// программа ничего не выводит, что в принципе логично;

int ElementsSum(int a, int b)
{
    return a <= b ? a + ElementsSum(a + 1, b) : 0;
}

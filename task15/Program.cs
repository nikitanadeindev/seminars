Console.Write("Введите цифру обозначающую день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if(dayOfWeek < 1 || dayOfWeek > 7)
    Console.WriteLine($"{dayOfWeek} -> такого дня недели нет");
else if(dayOfWeek == 6 || dayOfWeek == 7)
    Console.WriteLine($"{dayOfWeek} -> да");
else
    Console.WriteLine($"{dayOfWeek} -> нет");
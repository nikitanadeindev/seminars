// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double bp1, double kp1, double bp2, double kp2)
{
    double[] result = new double[2];
    double x = (bp1 - bp2) / (kp2 - kp1);
    double y = (kp2 * bp1 - kp1 * bp2) / (kp2 - kp1);
    result[0] = x;
    result[1] = y;
    return result;
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] result = IntersectionPoint(b1, k1, b2, k2);

Console.Write(k1 == k2 ? "Заданные прямые не пересекаются!"
                         : $"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({result[0]}; {result[1]})");
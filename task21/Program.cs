// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки az: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки by: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double Range3D (int xa, int ya, int za, int xb, int yb, int zb)
{
    double xc = (xa - xb) * (xa - xb);
    double yc = (ya - yb) * (ya - yb);
    double zc = (za - zb) * (za - zb);
    double sqrt = Math.Sqrt(xc + yc + zc);
    
    return Math.Round(sqrt, 2, MidpointRounding.ToZero);
}

double res = Range3D(ax, ay, az, bx, by, bz);
Console.WriteLine($"A({ax},{ay},{az}); B({bx},{by},{bz}) -> {res}");
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int x = x2 - x1;
int y = y2 - y1;
int z = z1 - z2;

double length = Math.Sqrt(x * x + y * y + z * z);
Console.WriteLine($"Расстояние между точками: {lenght}");
Console.Clear();

System.Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);
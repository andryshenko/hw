Console.Clear();

System.Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a > max) max = a;
min = b;
if (b > max) max = b;
min = a;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
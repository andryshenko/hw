Console.Clear();
// Вариант 1
// Console.WriteLine("Введите любое число: ");

// string? str = Console.ReadLine();
// if (str == null) return;

// System.Console.WriteLine(str[2]);

// Вариант 2
Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n>999)
{
    n=n/10;
    System.Console.WriteLine(n);
}
System.Console.WriteLine(n%10);

// Вариант 3
// Console.Write("Введите любое число: ");
// int a=Convert.ToInt32(Console.ReadLine());
// int b=a.ToString().Length;
// int divider=Convert.ToInt32(Math.Pow(10, b-3));

// if (b<3)
// {
//     Console.WriteLine("Третья цифра отсутствует");
// }
// else
// {
//     Console.WriteLine((a/divider)%10);
// }
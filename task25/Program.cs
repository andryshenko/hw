// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Clear();

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i <= b; i++)
{
    result *= a;
}
System.Console.WriteLine($"ОТВЕТ: {a}^{b} = {result}");

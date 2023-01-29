// Напишите программу, которая на входе принимает число 
// и выдает сумму цифр в числе.   (452 = 4+5+2 = 11)
Console.Clear();
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = 0;

while (a != 0)
{
    result += a % 10;
    a /= 10;
}
Console.WriteLine($"Сумма цифр в числе = {result}");
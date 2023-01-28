// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// Вариант 1
// for (int i=1; i<=n; i++)
// {
//     System.Console.Write($" {i*i*i} ");
// }

// Вариант 2
int stepen = 3;
Console.WriteLine("n ^ 3 = " + Math.Pow(n, stepen));
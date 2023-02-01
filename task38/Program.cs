// Задайте массив вещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.Write("Укажите массив: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
            {
                min = numbers[i];
            }
}

Console.WriteLine();
Console.WriteLine($"Максимальное число = {max}, минимальное число = {min}");
// Console.WriteLine();
Console.WriteLine($"Разница между числами = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
}
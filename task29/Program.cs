//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(number + 1);
    Console.Write(array[i] + ", ");
}

System.Console.WriteLine();

// int index = 0;

// if (index <= 8)
// {
//     Console.Write("ОШИБКА - Массив более 8 символов!");
// }
// Хочу ограничить ввод массива более 8 символов, но что-то видимо
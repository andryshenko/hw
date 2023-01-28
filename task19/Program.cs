Console.Clear();

Console.WriteLine("Введите **ПЯТИЗНАЧНОЕ** число: ");
string number = Console.ReadLine();
int lenght = number.Length;

if (lenght == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом");
    }
}
else
{
    Console.WriteLine("ОШИБКА - введено не пятизначное число");
}

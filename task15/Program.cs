Console.WriteLine("Является ли этот день недели - Выходным?");
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);

{
int day = number;
if(day >= 1 && day <= 5)
    {
        Console.WriteLine("нет");
    }

    else Console.WriteLine("да");
      
}
Console.Clear();
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

// int a=7;
// switch (a)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         System.Console.WriteLine("Рабочий день");
//         break;
//     case 6:
//     case 7:
//         System.Console.WriteLine("Выходной");
//         break;
//     default:
//         System.Console.WriteLine("Нет такого дня недели");
//         break;
// }
Console.Clear();

System.Console.Write("Введите число --> ");
int a=Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    int b = a % 2;
    System.Console.WriteLine("Четное");    
}
else
{
    System.Console.WriteLine("Не четное");    
}